﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Store.Services.ShoppingCartAPI.DTOs;

public class CartHeaderDto
{
    public Guid Id { get; set; }
    public string? UserId { get; set; }
    public string? CouponCode { get; set; }
    public double DiscountTotal { get; set; }
    public double CartTotal { get; set; }
}
