
from Tea.model import TeaModel


class Config(TeaModel):
    def __init__(self):
        super().__init__()
        self.endpoint = ""
        self.domain_id = ""
        self.client_id = ""
        self.refresh_token = ""
        self.client_secret = ""
        self.access_token = ""
        self.expire_time = ""
