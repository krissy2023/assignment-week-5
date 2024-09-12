using IndustryConnect_Week5_WebApi.Dtos;
using IndustryConnect_Week5_WebApi.Models;

namespace IndustryConnect_Week5_WebApi.Mappers
{
    public static class SaleMapper
    {
        public static Sale DtoToEntity(SaleDto sale)
        {
            var entity = new Sale
            {
                Id = sale.Id,
                CustomerId = sale?.CustomerId,
                ProductId = sale?.ProductId,
                StoreId = sale?.StoreId,
                DateSold = sale?.DateSold

            };

            return entity;
        }

        public static SaleDto EntityToDto(Sale sale)
        {
            var dto = new SaleDto
            {
                Id = sale.Id,
                CustomerId = sale?.CustomerId,
                ProductId = sale?.ProductId,
                StoreId = sale?.StoreId,
                CustomerName = $"{sale?.Customer?.FirstName} {sale?.Customer?.LastName}",
                ProductName = sale?.Product?.Name,
                StoreName = sale?.Store?.Name,
                DateSold = sale?.DateSold
            };

            return dto;
        }

       


    }
}
