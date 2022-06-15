using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebProject.API.DomainModels;
using WebProject.API.Repositories;

namespace WebProject.API.Controllers
{
    [ApiController]
    public class GendersController : Controller
    {
        private readonly IStudentRepository _studentRepository;
        private readonly IMapper _mapper;

        public GendersController(IStudentRepository studentRepository, IMapper mapper)
        {
            _studentRepository = studentRepository;
            _mapper = mapper;
        }
        [HttpGet]
        [Route("[controller]")]
        public async Task<IActionResult> GetAllGenders()
        {
            var genderList = await _studentRepository.GetGendersListAsync();
            if (!genderList.Any())
            {
                return NotFound();
            }

            return Ok(_mapper.Map <List<DoGender>>(genderList));
        }
    }
}