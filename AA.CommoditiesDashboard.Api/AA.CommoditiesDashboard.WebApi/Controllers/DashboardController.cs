using AA.CommoditiesDashboard.Service;
using AA.CommoditiesDashboard.Service.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace AA.CommoditiesDashboard.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DashboardController : ControllerBase
    {
        private readonly ICommoditiesService _commoditiesService;
        public DashboardController(ICommoditiesService commoditiesService)
        {
            _commoditiesService = commoditiesService;
        }

        [HttpGet]
        public async Task<IEnumerable<TradeActionHistoryDto>> Get()
        {
            return await _commoditiesService.GetTradeActionHistory();
        }


        public async Task<IEnumerable<TradeActionHistoryDto>> GetTradeActionHistory()
        {
            return await _commoditiesService.GetTradeActionHistory();
        }
        
    }
}