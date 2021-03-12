using Supermarket.API.Domain.Models;
using Supermarket.API.Domain.Services;
using System.Collections.Generic;
using System.Threading.Tasks;
using Supermarket.API.Domain.Repositories;
using Supermarket.API.Domain.Services.Communication;
using System;

namespace Supermarket.API.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
		private readonly IUnitOfWork _unitOfWork;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<IEnumerable<Category>> ListAsync()
        {
            return await _categoryRepository.ListAsync();
        }

		public async Task<SaveCategoryResponse> SaveAsync(Category category)
		{
			try
			{
				await _categoryRepository.AddAsync(category);
				await _unitOfWork.CompleteAsync();

				return new SaveCategoryResponse(category);
			}
			catch (Exception ex)
			{
				// Do some logging stuff
				return new SaveCategoryResponse($"An error occurred when saving the category: {ex.Message}");
			}
		}
	}
}
