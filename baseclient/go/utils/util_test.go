package utils

import (
	"io"
	"strings"
	"testing"
	"time"
)

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
	AssertContains(t, str, "Prettify")

	str = Prettify(nil)
	AssertEqual(t, "null", str)
}
