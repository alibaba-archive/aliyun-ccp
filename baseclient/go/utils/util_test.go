package utils

import (
	"testing"
)

func Test_GetRFC2616Date(t *testing.T) {
	time := GetRFC2616Date()
	AssertEqual(t, 29, len(time))
}
