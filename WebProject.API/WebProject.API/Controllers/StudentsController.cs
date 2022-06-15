using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebProject.API.DomainModels;
using WebProject.API.Repositories;

namespace WebProject.API.Controllers;

[ApiController]
public class StudentsController : Controller
{
    private readonly IStudentRepository _studentRepository;
    private readonly IMapper _mapper;

    public StudentsController(IStudentRepository studentRepository, IMapper mapper)
    {
        _studentRepository = studentRepository;
        _mapper = mapper;
    }

    // GET
    [HttpGet]
    [Route("[controller]")]
    public async Task<IActionResult> GetAllStudentsAsync()
    {
        var students = await _studentRepository.GetStudentsAsync();
        return Ok(_mapper.Map<List<DoStudent>>(students));

    }

    [HttpGet]
    [Route("[controller]/{studentId:guid}")]
    public async Task<IActionResult> GetStudentAsync([FromRoute] Guid studentId)
    {
        var student = await _studentRepository.GetStudentAsync(studentId);
        if (student == null) return NotFound();
        return Ok(_mapper.Map<DoStudent>(student));
    }
}