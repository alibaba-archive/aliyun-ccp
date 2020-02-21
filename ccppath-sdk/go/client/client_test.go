package client

import (
	"os"
	"testing"

	"github.com/alibabacloud-go/tea/utils"
)

func Test_api(t *testing.T) {
	config := new(Config).SetDomainId("sz16").
		SetAccessKeyId(os.Getenv("ACCESS_KEY_ID")).
		SetProtocol("http").
		SetAccessKeySecret(os.Getenv("ACCESS_KEY_SECRET"))
	ccpclient, err := NewClient(config)
	utils.AssertNil(t, err)
	listDriveRequest := new(ListDriveRequest).SetLimit(10)
	runtime := new(RuntimeOptions)
	resp, err := ccpclient.ListDrives(listDriveRequest, runtime)
	utils.AssertNil(t, err)
	utils.AssertEqual(t, len(resp.Items), 2)
	utils.AssertNotNil(t, resp.RequestId)
}
