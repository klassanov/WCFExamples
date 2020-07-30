using System.Runtime.Serialization;

namespace WcfServiceLibrarySuccess
{
    [DataContract]
    public class MathAnswer
    {
        public MathAnswer(decimal answer)
        {
            this.Answer = answer;
        }

        [DataMember]
        public decimal Answer { get; set; }
    }
}
