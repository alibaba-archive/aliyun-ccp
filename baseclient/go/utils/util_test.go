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
	Nums8    []int8
	Unum8    []uint8
	Value    string
	Time     time.Time
	Body     io.Reader
	Pipe     *io.PipeReader
	Mapvalue map[string]string
}

func Test_Prettify(t *testing.T) {
	prettifyTest := &PrettifyTest{
		name:     "prettify",
		Nums8:    []int8{0, 1, 2, 4},
		Unum8:    []uint8{0},
		Value:    "ok",
		Time:     time.Now(),
		Body:     interface{}(strings.NewReader("ccp")).(io.Reader),
		Pipe:     &io.PipeReader{},
		Mapvalue: map[string]string{"key": "ccp", "value": "ok"},
	}
	str := Prettify(prettifyTest)
	AssertContains(t, "Pipe: <buffer>", str)

	str = Prettify(nil)
	AssertContains(t, "", str)
}
