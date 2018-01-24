using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bigramy2
{
    public class Bigram
    {
        public  string name;
        public double value;

        public Bigram(string name, double value)
        {
            this.name = name;
            this.value = value;
        }

        public override string ToString()
        {
            return name + " " + value;
        }
    }
}
