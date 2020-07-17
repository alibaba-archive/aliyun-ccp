
from Tea.model import TeaModel


class Config(TeaModel):
    def __init__(
            self,
            endpoint='',
            domain_id='',
            client_id='',
            refresh_token='',
            client_secret='',
            access_token='',
            expire_time='',
    ):
        self.endpoint = endpoint
        self.domain_id = domain_id
        self.client_id = client_id
        self.refresh_token = refresh_token
        self.client_secret = client_secret
        self.access_token = access_token
        self.expire_time = expire_time
