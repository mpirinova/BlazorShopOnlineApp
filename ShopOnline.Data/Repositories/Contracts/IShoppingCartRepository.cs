﻿using ShopOnline.Data.Entities;
using ShopOnline.Models.Dtos;

namespace ShopOnline.Data.Repositories.Contracts
{
    public interface IShoppingCartRepository
    {
        Task<CartItemDto> AddItem(CartItemToAddDto cartItemToAddDto);

        Task<CartItemDto> UpdateQuantity(int id, CartItemQtyUpdateDto cartItemQtyUpdateDto);

        Task<CartItemDto> DeleteItem(int id);

        Task<CartItemDto> GetItem(int id);

        Task<IEnumerable<CartItemDto>> GetItems(int userId);
    }
}
