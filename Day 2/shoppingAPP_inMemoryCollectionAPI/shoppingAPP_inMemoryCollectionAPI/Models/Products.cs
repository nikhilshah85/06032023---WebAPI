namespace shoppingAPP_inMemoryCollectionAPI.Models
{
    public class Products
    {
        public int pId { get; set; }
        public string pName { get; set; }
        public string pCategory { get; set; }
        public double pPrice { get; set; }
        public bool pIsInStock { get; set; }

        static List<Products> pList = new List<Products>()
        {
            new Products(){ pId=101, pName="Pepsi", pCategory="Cold-Drink", pIsInStock=true, pPrice=50},
            new Products(){ pId=102, pName="IPhone", pCategory="Electronics", pIsInStock=true, pPrice=140000},
            new Products(){ pId=103, pName="Maggie", pCategory="Fast-Food", pIsInStock=false, pPrice=75},
            new Products(){ pId=104, pName="Appy", pCategory="Cold-Drink", pIsInStock=true, pPrice=125}
        };

        public List<Products> GetAllProducts()
        {
            return pList;
        }

        public Products GetProductById(int id)
        {
            var pr = pList.Find(p => p.pId == id);
            if (pr != null)
            {
                return pr;
            }
            throw new Exception("Product Not found");
        }

        public string AddNewProduct(Products newProduct)
        {
            //do some data validataion if needed
            pList.Add(newProduct);
            return "Product Added Successfully";
        }

        public string DeleteProduct(int id)
        {
            var pr = pList.Find(p => p.pId == id);
            if (pr != null)
            {
                pList.Remove(pr);
                return "Product Deleted Successfully";
            }
            throw new Exception("Product Not found");
        }

        public string EditProduct(Products changes)
        {
            var pr = pList.Find(p => p.pId == changes.pId);
            if (pr != null)
            {
                pr.pName = changes.pName;
                pr.pCategory = changes.pCategory;
                pr.pPrice = changes.pPrice;
                pr.pIsInStock = changes.pIsInStock;

                return "Product Edited Successfully";
            }
            throw new Exception("Product Not found");
        }

    }
}


























