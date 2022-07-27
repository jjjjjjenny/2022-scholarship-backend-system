using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using _2022_scholarship_backend_system.Models;

namespace _2022_scholarship_backend_system.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    [HttpGet("[action]")]
    public IActionResult SampleData()
    {
        var result = new List<WinnerListResult>();
        var winnersStudentInfo=new Dictionary<string, List<WinnersStudentInfo>>();
        winnersStudentInfo.Add(
            "A001-02", new List<WinnersStudentInfo>(){
                new WinnersStudentInfo{
                    id="M10909110",
                    major="資管碩二",
                    name="彭志鑫"
                },
                new WinnersStudentInfo{
                    id="M10909122",
                    major="資管碩二",
                    name="楊惠竹"
                },
                new WinnersStudentInfo{
                    id="M11009126",
                    major="資管碩一",
                    name="蔡佳軒"
                }

            }
        );
        winnersStudentInfo.Add(
            "A019-03", new List<WinnersStudentInfo>(){
                new WinnersStudentInfo{
                    id="B10705023",
                    major="四營建四甲",
                    name="呂沂倩"
                },
                new WinnersStudentInfo{
                    id="B10910137",
                    major="四設計商二乙",
                    name="張庭甄"
                }
            }
        );
        winnersStudentInfo.Add(
            "A037-01", new List<WinnersStudentInfo>(){
                new WinnersStudentInfo{
                    id="B10704021",
                    major="四材料四甲",
                    name="陳泊佑"
                },
            }

        );
        winnersStudentInfo.Add(
            "A001-03", new List<WinnersStudentInfo>(){
                new WinnersStudentInfo{
                    id="M10909110",
                    major="資管碩二",
                    name="彭志鑫"
                },
                new WinnersStudentInfo{
                    id="M10909122",
                    major="資管碩二",
                    name="楊惠竹"
                },
                new WinnersStudentInfo{
                    id="M11009126",
                    major="資管碩一",
                    name="蔡佳軒"
                }

            }
        );
        winnersStudentInfo.Add(
            "A001-04", new List<WinnersStudentInfo>(){
                new WinnersStudentInfo{
                    id="M10909110",
                    major="資管碩二",
                    name="彭志鑫"
                },
                new WinnersStudentInfo{
                    id="M10909122",
                    major="資管碩二",
                    name="楊惠竹"
                },
                new WinnersStudentInfo{
                    id="M11009126",
                    major="資管碩一",
                    name="蔡佳軒"
                }

            }
        );
        winnersStudentInfo.Add(
            "A001-05", new List<WinnersStudentInfo>(){
                new WinnersStudentInfo{
                    id="M10909110",
                    major="資管碩二",
                    name="彭志鑫"
                },
                new WinnersStudentInfo{
                    id="M10909122",
                    major="資管碩二",
                    name="楊惠竹"
                },
                new WinnersStudentInfo{
                    id="M11009126",
                    major="資管碩一",
                    name="蔡佳軒"
                }

            }
        );
        var winnersList= new List<WinnersList>();
        winnersList.Add(
            new WinnersList{
                id="A001-02",
                title="高興旺先生暨高瑞雯校友紀念獎學金",
                spot=3,
                amount=5000,
                onCampus=true,
            }
        );
        winnersList.Add(
            new WinnersList{
                id="A001-03",
                title="高興旺先生暨高瑞雯校友紀念獎學金",
                spot=3,
                amount=5000,
                onCampus=true,
            }
        );
        winnersList.Add(
            new WinnersList{
                id="A001-04",
                title="高興旺先生暨高瑞雯校友紀念獎學金",
                spot=3,
                amount=5000,
                onCampus=true,
            }
        );
        winnersList.Add(
            new WinnersList{
                id="A001-05",
                title="高興旺先生暨高瑞雯校友紀念獎學金",
                spot=3,
                amount=5000,
                onCampus=true,
            }
        );
        winnersList.Add(
            new WinnersList{
                id="A019-03",
                title="林草英教授紀念獎學金",
                spot=3,
                amount=10000,
                onCampus=true,
            }
        );
        winnersList.Add(
            new WinnersList{
                id="A037-01",
                title="毛氏嘯峰先生",
                spot=1,
                amount=3000,
                onCampus=false,
            }
        );
        result.Add( new WinnerListResult{
            WinnersList=winnersList,
            WinnersStudentInfo=winnersStudentInfo

        });
        return Ok(result);
    }
}
