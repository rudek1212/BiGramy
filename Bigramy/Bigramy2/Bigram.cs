using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bigramy2
{
    public class Bigram
    {
        public  string name;
        public float value;

        public Bigram(string name, float value)
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
