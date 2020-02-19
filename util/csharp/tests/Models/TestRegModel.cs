using System.Collections.Generic;
using Tea;

namespace tests.Models
{
    public class TestRegModel : TeaModel
    {
        [NameInMap("requestId")]
        [Validation(Pattern = "re", MaxLength = 0, Required = true)]
        public string RequestId { get; set; }

        [NameInMap("items")]
        [Validation(Required = true)]
        public List<TestRegSubModel> Items { get; set; }

        [NameInMap("next_marker")]
        [Validation(Pattern = "next", MaxLength = 0, Required = true)]
        public string NextMarker { get; set; }

        public string testNoAttr { get; set; }

        [NameInMap("testListStr")]
        [Validation(Pattern = "listStr", MaxLength = 0)]
        public List<string> testListStr { get; set; }

        public TestRegSubModel subModel { get; set; }
    }
}
