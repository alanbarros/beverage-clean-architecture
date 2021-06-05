using Domain.Interfaces;

namespace Application.Boundaries.HireDev
{
    public class HireDevOutput
    {
        public HireDevOutput(IDeveloper dev)
        {
            this.Dev = dev;

        }
        public IDeveloper Dev { get; set; }
    }
}