using Application.Boundaries;
using Application.Boundaries.HireDev;

namespace Standards
{
    public class Output : IOutputPort<HireDevOutput>
    {
        public HireDevOutput Result { get; set; }
        public string ErrorMsg { get; set;}

        public void Error(string message)
        {
            this.ErrorMsg = message;
        }

        public void Standard(HireDevOutput outPut)
        {
            Result = outPut;
        }
    }
}