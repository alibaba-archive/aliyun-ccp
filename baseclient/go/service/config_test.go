package service

import (
	"errors"
	"io"
	"io/ioutil"
	"net/http"
	"reflect"
	"strings"
	"testing"
	"time"

	"github.com/alibabacloud-go/tea/tea"
	"github.com/aliyun/aliyun-ccp/baseclient/go/utils"
)

type errLength struct {
	Num *int `json:"num" maxLength:"a"`
}

type PrettifyTest struct {
	name     string
	Strs     []string
	Value    string
	Time     time.Time
	Body     io.Reader
	Mapvalue map[string]string
	Prettify *PrettifyTest
}

func Test_Prettify(t *testing.T) {
	prettifyTest := PrettifyTest{
		name:     "prettify",
		Value:    "ok",
		Time:     time.Now(),
		Body:     interface{}(strings.NewReader("ccp")).(io.Reader),
		Mapvalue: map[string]string{"key": "ccp", "value": "ok"},
		Prettify: &PrettifyTest{
			Time:     time.Now(),
			Body:     interface{}(strings.NewReader("ccp")).(io.Reader),
			Mapvalue: map[string]string{"key": "ccp", "value": "ok"},
		},
	}
	str := Prettify(prettifyTest)
	utils.AssertContains(t, str, "Prettify")

	str = Prettify(nil)
	utils.AssertEqual(t, "null", str)
}

func Test_Sorter(t *testing.T) {
	tmp := map[string]string{
		"key":   "ccp",
		"value": "ok",
	}
	sort := newSorter(tmp)
	sort.Sort()

	len := sort.Len()
	utils.AssertEqual(t, len, 2)

	isLess := sort.Less(0, 1)
	utils.AssertEqual(t, isLess, true)

	sort.Swap(0, 1)
	isLess = sort.Less(0, 1)
	utils.AssertEqual(t, isLess, false)
}

func Test_getSignature(t *testing.T) {
	request := tea.NewRequest()
	request.Query = map[string]string{
		"ccp": "ok",
	}
	request.Headers = map[string]string{
		"x-acs-meta": "user",
	}
	str := getSignature(request, "")
	utils.AssertEqual(t, 28, len(str))
}

func Test_flatRepeatedList(t *testing.T) {
	input := map[string]interface{}{
		"Nums": []int{1, 2},
		"Maps": []map[string]string{
			map[string]string{
				"key": "value",
			},
		},
		"Nil": nil,
	}
	result := map[string]string{}
	flatRepeatedList(reflect.ValueOf(input), result, "")
	utils.AssertEqual(t, "2", result["Nums.2"])
	utils.AssertEqual(t, "1", result["Nums.1"])
	utils.AssertEqual(t, "value", result["Maps.1.key"])
}

func Test_refreshAccessToken(t *testing.T) {
	resp, err := hookdo(nil, nil)
	utils.AssertNil(t, resp)
	utils.AssertNil(t, err)

	originHook := hookdo
	defer func() {
		hookdo = originHook
	}()
	hookdo = func(response *tea.Response, err error) (*tea.Response, error) {
		return nil, errors.New("refresh_token error")
	}
	at, rt, up, err := refreshAccessToken("", "ccp", "refresh_token", "client_id", "client_secret")
	utils.AssertEqual(t, "", at)
	utils.AssertEqual(t, "", rt)
	utils.AssertNil(t, up)
	utils.AssertEqual(t, "refresh_token error", err.Error())

	hookdo = func(resp *tea.Response, err error) (*tea.Response, error) {
		tmp := `{"expire_time": 10}`
		httpresponse := &http.Response{
			StatusCode: 200,
			Body:       ioutil.NopCloser(strings.NewReader(tmp)),
		}
		resp = tea.NewResponse(httpresponse)
		return resp, nil
	}
	at, rt, up, err = refreshAccessToken("endpoint", "ccp", "refresh_token", "client_id", "client_secret")
	utils.AssertEqual(t, "", at)
	utils.AssertEqual(t, "", rt)
	utils.AssertNil(t, up)
	utils.AssertEqual(t, "json: cannot unmarshal number into Go struct field AccessTokenResponse.expire_time of type string", err.Error())

	hookdo = func(resp *tea.Response, err error) (*tea.Response, error) {
		tmp := `{"expire_time": "2006-01-02T15:04:05Z","access_token":"access_token","refresh_token":"refresh_token"}`
		httpresponse := &http.Response{
			StatusCode: 200,
			Body:       ioutil.NopCloser(strings.NewReader(tmp)),
		}
		resp = tea.NewResponse(httpresponse)
		return resp, nil
	}
	at, rt, up, err = refreshAccessToken("endpoint", "ccp", "refresh_token", "client_id", "client_secret")
	utils.AssertEqual(t, "access_token", at)
	utils.AssertEqual(t, "refresh_token", rt)
	utils.AssertNil(t, err)
	utils.AssertNotNil(t, up)

	ifUpdate := up.needUpdateCredential()
	utils.AssertEqual(t, true, ifUpdate)
}

func Test_getFunc(t *testing.T) {
	num := 10
	intval := getIntValue(num)
	utils.AssertEqual(t, 10, intval)

	intval = getIntValue(nil)
	utils.AssertEqual(t, 0, intval)

	boolval := true
	boolval = getBoolValue(boolval)
	utils.AssertEqual(t, true, boolval)

	boolval = getBoolValue(nil)
	utils.AssertEqual(t, false, boolval)
}
