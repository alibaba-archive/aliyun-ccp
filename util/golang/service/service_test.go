package service

import (
	"reflect"
	"testing"

	"github.com/alibabacloud-go/tea/tea"
	"github.com/alibabacloud-go/tea/utils"
)

func Test_GetPathname(t *testing.T) {
	pathName := GetPathname("", "/v2")
	utils.AssertEqual(t, "/v2", pathName)

	pathName = GetPathname("ccp", "/v2")
	utils.AssertEqual(t, "/ccp/v2", pathName)
}

func Test_GetSignature(t *testing.T) {
	request := tea.NewRequest()
	signature := GetSignature(request, "secret")
	utils.AssertEqual(t, 28, len(signature))
}

func Test_ToQuery(t *testing.T) {
	input := map[string]interface{}{
		"key":    "ccp",
		"value":  "ok",
		"number": 1,
	}
	out := ToQuery(input)
	utils.AssertEqual(t, "ccp", out["key"])
	utils.AssertEqual(t, "ok", out["value"])
	utils.AssertEqual(t, "1", out["number"])
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
