using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ocean.sdk.entity
{
    public class ApplicationResp
    {
        public string message { get; set; }

        public AppData data { get; set; }

        public int    status { get; set; }

        public string errorCode { get; set; }

        public string errorMessage { get; set; }

        public string exception { get; set; }
    }

    public class AppInfo
    {
        public string id { get; set; }

        public string applicationName { get; set; }

        public int applicationType { get; set; }

        public string applicationLogo { get; set; }

        public string applicationSummary { get; set; }

        public string applicationWebsite { get; set; }

        public int authorizationType { get; set; }

        public string applicationId { get; set; }

        public string applicationKey { get; set; }

        public int enabled { get; set; }

        public string createTime { get; set; }

        public int userId { get; set; }

        public int userType { get; set; }

        public string callbackAddress { get; set; }

        public string remark { get; set; }

        public string approver { get; set; }

        public string companyName { get; set; }

        public string contactPhone { get; set; }

        public string contactEmail { get; set; }

        public string businessLicenceNo { get; set; }

        public string businessLicencePic { get; set; }

        public string linkMan { get; set; }

        public string certNo { get; set; }

        public string certFrontPic { get; set; }

        public string certBackPic { get; set; }
    }

    public class AppData
    {
        public int pageNum { get; set; }

        public int pageSize { get; set; }

        public int size { get; set; }

        public string orderBy { get; set; }

        public int startRow { get; set; }

        public int endRow { get; set; }

        public int total { get; set; }

        public int pages { get; set; }

        public IList<AppInfo> list { get; set; } = new List<AppInfo>();

        public int firstPage { get; set; }

        public int prePage { get; set; }

        public int nextPage { get; set; }

        public int lastPage { get; set; }

        public bool isFirstPage { get; set; }

        public bool isLastPage { get; set; }

        public bool hasPreviousPage { get; set; }

        public bool hasNextPage { get; set; }

        public int navigatePages { get; set; }
    }
}
