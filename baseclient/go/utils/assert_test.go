package utils

import (
	"net/http"
	"testing"
)

func Test_isNil(t *testing.T) {
	isnil := isNil(nil)
	AssertEqual(t, true, isnil)
	var req *http.Request
	isnil = isNil(req)
	AssertEqual(t, true, isnil)
	AssertNil(t, nil)
	AssertNotNil(t, "sdk")

	isContains := AssertContains(t, "tea test", "test")
	AssertEqual(t, true, isContains)

	isContains = AssertContains(t, "tea test", "txt")
	AssertEqual(t, false, isContains)
}
