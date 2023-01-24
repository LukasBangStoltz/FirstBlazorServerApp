namespace FirstBlazorServerApp.Configuration
{
    public class PagingConfig
    {
        public bool Enabled { get; set; }
        public int PageSize { get; set; }
        public bool CustomPager { get; set; }

        public int NumberOfItemsToSkip(int pageNumber)
        {
            if (Enabled)
            {
                return (pageNumber - 1) * PageSize;
            }
            return 0;
        }
        public int NumberOfItemsToTake(int totalItemsCount)
        {
            if (Enabled)
            {
                return PageSize;
            }
            return totalItemsCount;
        }

        public int PrevPageNumber(int currentPageNumber)
        {
            if (currentPageNumber > 1)
            {
                return currentPageNumber - 1;
            }
            else
            {
                return 1;
            }
        }

        public int NextPageNumber(int currentPageNumber, int totalItemsCount)
        {
            if (currentPageNumber < MaxPageNumber(totalItemsCount))
            {
                return currentPageNumber + 1;
            }
            else
            {
                return currentPageNumber;
            }

        }

        public int MaxPageNumber(int totalItemsCount)
        {
            int maxPageNumber;
            double numberOfPages = (double)totalItemsCount / (double)PageSize;
            if (numberOfPages < Math.Floor(numberOfPages))
            {
                maxPageNumber = (int)numberOfPages;
            }
            else
            {
                maxPageNumber = (int)numberOfPages + 1;
            }
            return maxPageNumber;
        }
    }
}
