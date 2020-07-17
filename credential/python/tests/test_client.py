import unittest
import datetime

from Tea.exceptions import TeaException

from alibabacloud_ccp_credentials.client import Client
from alibabacloud_ccp_credentials.models import Config


class TestClient(unittest.TestCase):

    def test_Credential(self):
        config = Config()
        config.refresh_token = "refreshToken"
        config.domain_id = "domainId"
        config.client_id = "clientId"
        config.client_secret = "clientSecret"
        config.expire_time = "2019-10-01T00:00:00Z"

        access_token_credential = Client(config)
        self.assertEqual("2019-10-01T00:00:00Z",
                         access_token_credential.get_expire_time())

        access_token_credential.set_access_token("accessToken")
        self.assertRaises(TeaException, access_token_credential.get_access_token)

        date_feature = (datetime.datetime.now() +
                        datetime.timedelta(days=1)).strftime("%Y-%m-%d %H:%M:%S")
        access_token_credential.set_expire_time(date_feature)
        self.assertEqual(
            "accessToken", access_token_credential.get_access_token()
        )

        access_token_credential.set_refresh_token("test")
        self.assertEqual("test", access_token_credential.get_refresh_token())

