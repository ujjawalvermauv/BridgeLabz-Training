using System;

class Product
{
    private string ProductName{get;set;}
    private int ProductId{get;set;}
    private double Discount{get;set;};

    public Product(string ProductName,int ProductId,double Discount)
    {
        this.ProductName=ProductName;
        this.Discount=Discount;
        this.ProductId=ProductId;
        
    }
    public override string ToString()
    {
        return this.ProductName + "ProductName" + this.Discount +"Discount" + this.ProductId+"productid";
    }


}
class  QuicSosrtUtil
{
    public void sort(Product [] products)
    {
        int n= products.length;
        for(int i = 0; i < n - 1; i++)
        {
            for(int j = 0; j < n - i - 1; j++)
            {
                
            }
        }
    }
}