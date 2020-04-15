import unittest
import requests
import datetime

from ccp_credentials.client import AccessTokenCredential
from ccp_credentials.models import Config


class TestClient(unittest.TestCase):

    def test_AccessTokenCredential(self):
        config = Config()
        config.refresh_token = "refreshToken"
        config.domain_id = "domainId"
        config.client_id = "clientId"
        config.client_secret = "clientSecret"
        config.expire_time = "2019-10-01T00:00:00"

        access_token_credential = AccessTokenCredential(config)
        self.assertEqual("2019-10-01T00:00:00",
                         access_token_credential.get_expire_time())
        self.assertRaises(requests.exceptions.ConnectionError,
                          access_token_credential.get_access_token)

        access_token_credential.set_access_token("accessToken")
        self.assertRaises(requests.exceptions.ConnectionError,
                          access_token_credential.get_access_token)

        date_feature = (datetime.datetime.now() +
                        datetime.timedelta(days=1)).strftime("%Y-%m-%d %H:%M:%S")
        access_token_credential.set_expire_time(date_feature)
        self.assertEqual(
            "accessToken", access_token_credential.get_access_token())

        access_token_credential.set_refresh_token("test")
        self.assertEqual("test", access_token_credential.get_refresh_token())
