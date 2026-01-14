using System.Text;

StringBuilder sb = new StringBuilder();
for (int i = 0; i < 10000; i++)
{
    sb.Append("Hello");
}
string result = sb.ToString();
