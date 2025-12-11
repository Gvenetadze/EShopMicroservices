namespace Ordering.Application.Dto;

public record OrderDto(
    Guid Id,
    string CustomerId,
    string OrderName,
    AddressDto ShippingAddress,
    AddressDto BillingAddress,
    PaymentDto Payment,
    OrderStatus status,
    List<OrderItemDto> OrderItems
);