using System.Data.SqlClient;


namespace BeneficiarioAPI.Data
{
    public class beneficiariosData
    {
        SqlConnection cnstr = new SqlConnection(@"server=XXXXXX\SQLEXPRESS; database=dbBeneficiarios; user id=XXXsaXXX; password=XXXXXX; Trusted_Connection= True; MultipleActiveResultSets= True;TrustServerCertificate= true;Encrypt= true");
        public SqlConnection getConnection
        {
            get { return cnstr; }
        }
    }
}
