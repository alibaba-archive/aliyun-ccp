package utils

import (
	"net/http"
	"testing"
)

func Test_Assert(t *testing.T) {
	isnil := isNil(nil)
	AssertEqual(t, true, isnil)
	var req *http.Request
	isnil = isNil(req)
	AssertEqual(t, true, isnil)
	AssertNil(t, nil)
	AssertNotNil(t, "sdk")

	AssertContains(t, "tea test", "test")

	hookdo(nil)
	originhook := hookdo
	defer func() {
		hookdo = originhook
	}()

	hookdo = func(errorf func(format string, args ...interface{})) func(format string, args ...interface{}) {
		return func(format string, args ...interface{}) {}
	}

	AssertEqual(t, false, isnil)
	AssertNil(t, "ok")
	AssertNotNil(t, nil)

	AssertContains(t, "tea test", "txt")
}
