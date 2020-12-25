using AutoMapper;
using Basket.API.Entities;
using EventBus.RabbitMq.Events;
namespace Basket.API.Mappings
{
    public class BasketMapping : Profile
    {
        public BasketMapping()
        {
            CreateMap<BasketCheckout, BasketCheckoutEvent>().ReverseMap();
        }
    }
}