using Microsoft.EntityFrameworkCore;
using NichDevDotNetCore.Data;
using NichDevDotNetCore.Models.ViewModels;
using NichDevDotNetCore.Repositories;
using NichDevDotNetCore.Services;

namespace NichDevDotNetCore.Builders
{
    public class HomeViewModelBuilder
    {
        public ApplicationDbContext _context { get; }
        public ICatFactService _catFactService { get; }
        private readonly PostRepository _postRepository;

        public HomeViewModelBuilder(ApplicationDbContext context, ICatFactService catFactService)
        {
            _context = context;
            _catFactService = catFactService;
            _postRepository = new PostRepository(context);
        }

        public async Task<PostsViewModel> BuildIndexAsync()
        {
            PostsViewModel viewModel = new PostsViewModel();
            var posts = _postRepository.GetAll();
            viewModel.Posts = posts;

            viewModel.CatFact = await _catFactService.GetCatFact();

            return viewModel;
        }
    }
}
