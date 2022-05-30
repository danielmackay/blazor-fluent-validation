namespace BlazorFluentValidation.Client.Models;

public class OrderModel
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string CCNumber { get; set; } = "4012 8888 8888 1881";
    public AddressModel Address { get; set; } = new AddressModel();
    public List<OrderDetailsModel> OrderDetails = new List<OrderDetailsModel>()
        {
            new OrderDetailsModel()
                {
                    Description = "Perform Work order 1",
                    Offer = 100
                },
            new OrderDetailsModel()
        };
}

