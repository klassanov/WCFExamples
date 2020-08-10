using System.Runtime.Serialization;

namespace WcfServiceLibrarySuccess.Models
{
    [DataContract(Name = "RispostaMatematica", Namespace = "alexitaliano")]
    public class MathAnswer
    {
        public MathAnswer(decimal answer)
        {
            this.Answer = answer;
        }

        public MathAnswer(decimal answer, int greeting = 10) : this(answer)
        {
            this.Greeting = greeting;
        }

        [DataMember(Name = "Risposta")]
        public decimal Answer { get; set; }



        public int Greeting { get; set; }

        [DataMember]
        public AnswerQuality Quality { get; set; }
    }


    [DataContract]
    public enum AnswerQuality
    {
        [EnumMember(Value = "A class")]
        High,

        [EnumMember]
        Low
    }
}
