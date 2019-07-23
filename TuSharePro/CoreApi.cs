using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using TuSharePro.Models.Request;
using TuSharePro.Models.Response;

namespace TuSharePro
{
    public class CoreApi
    {
        private string token = null;
        public const string url = "http://api.tushare.pro";

        public CoreApi(string token)
        {
            this.token = token;
        }
        public CoreApi()
        {
            
        }
        public string Token { get => token; set => token = value; }

        #region 行情接口
        /// <summary>
        /// 股票-日线行情
        /// </summary>
        /// <param name="ts_code"></param>
        /// <param name="trade_date"></param>
        /// <param name="start_date"></param>
        /// <param name="end_date"></param>

        public _BaseResponse daily(string ts_code, string trade_date, string start_date, string end_date)
        {
            try
            {
                Dictionary<string, string> paramsList = new Dictionary<string, string>();
                paramsList.Add("ts_code", ts_code);
                paramsList.Add("trade_date", trade_date);
                paramsList.Add("start_date", start_date);
                paramsList.Add("end_date", end_date);
                BarRequest request = new BarRequest
                {
                    token = Token,
                    api_name = "daily",
                    paramsList = paramsList
                };
                string json = JsonConvert.SerializeObject(request, 
                    new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore
                });
                return request.Request<_BaseResponse>(url, json);
            }
            catch (Exception ex)
            {
                return new _BaseResponse() { code = -1, msg = ex.Message };
            }
            
        }

        /// <summary>
        /// 股票-周线行情
        /// </summary>
        /// <param name="ts_code"></param>
        /// <param name="trade_date"></param>
        /// <param name="start_date"></param>
        /// <param name="end_date"></param>

        public _BaseResponse weekly(string ts_code, string trade_date, string start_date, string end_date)
        {
            try
            {
                Dictionary<string, string> paramsList = new Dictionary<string, string>();
                paramsList.Add("ts_code", ts_code);
                paramsList.Add("trade_date", trade_date);
                paramsList.Add("start_date", start_date);
                paramsList.Add("end_date", end_date);
                BarRequest request = new BarRequest
                {
                    token = Token,
                    api_name = "weekly",
                    paramsList = paramsList
                };
                string json = JsonConvert.SerializeObject(request,
                    new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });
                return request.Request<_BaseResponse>(url, json);
            }
            catch (Exception ex)
            {
                return new _BaseResponse() { code = -1, msg = ex.Message };
            }

        }

        /// <summary>
        /// 股票-月线行情
        /// </summary>
        /// <param name="ts_code"></param>
        /// <param name="trade_date"></param>
        /// <param name="start_date"></param>
        /// <param name="end_date"></param>

        public _BaseResponse monthly(string ts_code, string trade_date, string start_date, string end_date)
        {
            try
            {
                Dictionary<string, string> paramsList = new Dictionary<string, string>();
                paramsList.Add("ts_code", ts_code);
                paramsList.Add("trade_date", trade_date);
                paramsList.Add("start_date", start_date);
                paramsList.Add("end_date", end_date);
                BarRequest request = new BarRequest
                {
                    token = Token,
                    api_name = "monthly",
                    paramsList = paramsList
                };
                string json = JsonConvert.SerializeObject(request,
                    new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });
                return request.Request<_BaseResponse>(url, json);
            }
            catch (Exception ex)
            {
                return new _BaseResponse() { code = -1, msg = ex.Message };
            }

        }

        /// <summary>
        /// 指数-日线行情
        /// </summary>
        /// <param name="ts_code"></param>
        /// <param name="trade_date"></param>
        /// <param name="start_date"></param>
        /// <param name="end_date"></param>

        public _BaseResponse index_daily(string ts_code, string trade_date, string start_date, string end_date)
        {
            try
            {
                Dictionary<string, string> paramsList = new Dictionary<string, string>();
                paramsList.Add("ts_code", ts_code);
                paramsList.Add("trade_date", trade_date);
                paramsList.Add("start_date", start_date);
                paramsList.Add("end_date", end_date);
                BarRequest request = new BarRequest
                {
                    token = Token,
                    api_name = "index_daily",
                    paramsList = paramsList
                };
                string json = JsonConvert.SerializeObject(request,
                    new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });
                return request.Request<_BaseResponse>(url, json);
            }
            catch (Exception ex)
            {
                return new _BaseResponse() { code = -1, msg = ex.Message };
            }

        }

        /// <summary>
        /// 指数-周线行情
        /// </summary>
        /// <param name="ts_code"></param>
        /// <param name="trade_date"></param>
        /// <param name="start_date"></param>
        /// <param name="end_date"></param>

        public _BaseResponse index_weekly(string ts_code, string trade_date, string start_date, string end_date)
        {
            try
            {
                Dictionary<string, string> paramsList = new Dictionary<string, string>();
                paramsList.Add("ts_code", ts_code);
                paramsList.Add("trade_date", trade_date);
                paramsList.Add("start_date", start_date);
                paramsList.Add("end_date", end_date);
                BarRequest request = new BarRequest
                {
                    token = Token,
                    api_name = "index_weekly",
                    paramsList = paramsList
                };
                string json = JsonConvert.SerializeObject(request,
                    new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });
                return request.Request<_BaseResponse>(url, json);
            }
            catch (Exception ex)
            {
                return new _BaseResponse() { code = -1, msg = ex.Message };
            }

        }

        /// <summary>
        /// 指数-月线行情
        /// </summary>
        /// <param name="ts_code"></param>
        /// <param name="trade_date"></param>
        /// <param name="start_date"></param>
        /// <param name="end_date"></param>

        public _BaseResponse index_monthly(string ts_code, string trade_date, string start_date, string end_date)
        {
            try
            {
                Dictionary<string, string> paramsList = new Dictionary<string, string>();
                paramsList.Add("ts_code", ts_code);
                paramsList.Add("trade_date", trade_date);
                paramsList.Add("start_date", start_date);
                paramsList.Add("end_date", end_date);
                BarRequest request = new BarRequest
                {
                    token = Token,
                    api_name = "index_monthly",
                    paramsList = paramsList
                };
                string json = JsonConvert.SerializeObject(request,
                    new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });
                return request.Request<_BaseResponse>(url, json);
            }
            catch (Exception ex)
            {
                return new _BaseResponse() { code = -1, msg = ex.Message };
            }

        }
        #endregion

        #region 信息接口
        /// <summary>
        /// 市场信息-股票列表
        /// </summary>
        /// <param name="is_hs"></param>
        /// <param name="list_status"></param>
        /// <param name="exchange"></param>
        public _BaseResponse stock_basic(string is_hs, string list_status, string exchange)
        {
            try
            {
                Dictionary<string, string> paramsList = new Dictionary<string, string>();
                paramsList.Add("is_hs", is_hs);
                paramsList.Add("list_status", list_status);
                paramsList.Add("exchange", exchange);
                
                StockBasicRequest request = new StockBasicRequest
                {
                    token = Token,
                    api_name = "stock_basic",
                    paramsList = paramsList
                };
                string json = JsonConvert.SerializeObject(request,
                    new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });
                return request.Request<_BaseResponse>(url, json);
            }
            catch (Exception ex)
            {
                return new _BaseResponse() { code = -1, msg = ex.Message };
            }
        }

        /// <summary>
        /// 市场信息-交易日历
        /// </summary>
        /// <param name="exchange"></param>
        /// <param name="start_date"></param>
        /// <param name="end_date"></param>
        /// <param name="is_open"></param>
        public _BaseResponse trade_cal(string exchange, string start_date, string end_date,string is_open)
        {
            try
            {
                Dictionary<string, string> paramsList = new Dictionary<string, string>();
                paramsList.Add("exchange", exchange);
                paramsList.Add("start_date", start_date);
                paramsList.Add("end_date", end_date);
                paramsList.Add("is_open", is_open);
                TradeCalRequest request = new TradeCalRequest
                {
                    token = Token,
                    api_name = "trade_cal",
                    paramsList = paramsList
                };
                string json = JsonConvert.SerializeObject(request,
                    new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });
                return request.Request<_BaseResponse>(url, json);
            }
            catch (Exception ex)
            {
                return new _BaseResponse() { code = -1, msg = ex.Message };
            }

        }

        /// <summary>
        /// 市场信息-沪深股通成份股
        /// </summary>
        /// <param name="hs_type"></param>
        /// <param name="is_new"></param>

        public _BaseResponse hs_const(string hs_type, string is_new)
        {
            try
            {
                Dictionary<string, string> paramsList = new Dictionary<string, string>();
                paramsList.Add("hs_type", hs_type);
                paramsList.Add("is_new", is_new);
                HsConstRequest request = new HsConstRequest
                {
                    token = Token,
                    api_name = "hs_const",
                    paramsList = paramsList
                };
                string json = JsonConvert.SerializeObject(request,
                    new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });
                return request.Request<_BaseResponse>(url, json);
            }
            catch (Exception ex)
            {
                return new _BaseResponse() { code = -1, msg = ex.Message };
            }

        }

        /// <summary>
        /// 市场信息-上市公司基本信息
        /// </summary>
        /// <param name="exchange"></param>
        public _BaseResponse stock_company(string exchange)
        {
            try
            {
                Dictionary<string, string> paramsList = new Dictionary<string, string>();
                paramsList.Add("exchange", exchange);
                StockCompanyRequest request = new StockCompanyRequest
                {
                    token = Token,
                    api_name = "stock_company",
                    paramsList = paramsList
                };
                string json = JsonConvert.SerializeObject(request,
                    new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });
                return request.Request<_BaseResponse>(url, json);
            }
            catch (Exception ex)
            {
                return new _BaseResponse() { code = -1, msg = ex.Message };
            }

        }

        /// <summary>
        /// 市场信息-上市公司基本信息
        /// </summary>
        /// <param name="start_date"></param>
        /// <param name="end_date"></param>
        public _BaseResponse new_share(string start_date, string end_date)
        {
            try
            {
                Dictionary<string, string> paramsList = new Dictionary<string, string>();
                paramsList.Add("start_date", start_date);
                paramsList.Add("end_date", end_date);
                NewShareRequest request = new NewShareRequest
                {
                    token = Token,
                    api_name = "new_share",
                    paramsList = paramsList
                };
                string json = JsonConvert.SerializeObject(request,
                    new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });
                return request.Request<_BaseResponse>(url, json);
            }
            catch (Exception ex)
            {
                return new _BaseResponse() { code = -1, msg = ex.Message };
            }
        }

        /// <summary>
        /// 股票信息-股票曾用名
        /// </summary>
        /// <param name="ts_code"></param>
        /// <param name="start_date"></param>
        /// <param name="end_date"></param>
        public _BaseResponse namechange(string ts_code, string start_date, string end_date)
        {
            try
            {
                Dictionary<string, string> paramsList = new Dictionary<string, string>();
                paramsList.Add("ts_code", ts_code);
                paramsList.Add("start_date", start_date);
                paramsList.Add("end_date", end_date);
                NameChangeRequest request = new NameChangeRequest
                {
                    token = Token,
                    api_name = "namechange",
                    paramsList = paramsList
                };
                string json = JsonConvert.SerializeObject(request,
                    new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });
                return request.Request<_BaseResponse>(url, json);
            }
            catch (Exception ex)
            {
                return new _BaseResponse() { code = -1, msg = ex.Message };
            }

        }

        /// <summary>
        /// 股票信息-复权因子
        /// </summary>
        /// <param name="ts_code"></param>
        /// <param name="trade_date"></param>
        /// <param name="start_date"></param>
        /// <param name="end_date"></param>
        public _BaseResponse adj_factor(string ts_code, string trade_date, string start_date, string end_date)
        {
            try
            {
                Dictionary<string, string> paramsList = new Dictionary<string, string>();
                paramsList.Add("ts_code", ts_code);
                paramsList.Add("trade_date", trade_date);
                paramsList.Add("start_date", start_date);
                paramsList.Add("end_date", end_date);
                AdjFactorRequest request = new AdjFactorRequest
                {
                    token = Token,
                    api_name = "adj_factor",
                    paramsList = paramsList
                };
                string json = JsonConvert.SerializeObject(request,
                    new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });
                return request.Request<_BaseResponse>(url, json);
            }
            catch (Exception ex)
            {
                return new _BaseResponse() { code = -1, msg = ex.Message };
            }

        }

        /// <summary>
        /// 股票信息-每日指标
        /// </summary>
        /// <param name="ts_code"></param>
        /// <param name="trade_date"></param>
        /// <param name="start_date"></param>
        /// <param name="end_date"></param>
        public _BaseResponse daily_basic(string ts_code, string trade_date, string start_date, string end_date)
        {
            try
            {
                Dictionary<string, string> paramsList = new Dictionary<string, string>();
                paramsList.Add("ts_code", ts_code);
                paramsList.Add("trade_date", trade_date);
                paramsList.Add("start_date", start_date);
                paramsList.Add("end_date", end_date);
                DailyBasicRequest request = new DailyBasicRequest
                {
                    token = Token,
                    api_name = "daily_basic",
                    paramsList = paramsList
                };
                string json = JsonConvert.SerializeObject(request,
                    new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });
                return request.Request<_BaseResponse>(url, json);
            }
            catch (Exception ex)
            {
                return new _BaseResponse() { code = -1, msg = ex.Message };
            }

        }

        /// <summary>
        /// 股票信息-个股资金流向
        /// </summary>
        /// <param name="ts_code"></param>
        /// <param name="trade_date"></param>
        /// <param name="start_date"></param>
        /// <param name="end_date"></param>
        public _BaseResponse moneyflow(string ts_code, string trade_date, string start_date, string end_date)
        {
            try
            {
                Dictionary<string, string> paramsList = new Dictionary<string, string>();
                paramsList.Add("ts_code", ts_code);
                paramsList.Add("trade_date", trade_date);
                paramsList.Add("start_date", start_date);
                paramsList.Add("end_date", end_date);
                MoneyFlowRequest request = new MoneyFlowRequest
                {
                    token = Token,
                    api_name = "moneyflow",
                    paramsList = paramsList
                };
                string json = JsonConvert.SerializeObject(request,
                    new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });
                return request.Request<_BaseResponse>(url, json);
            }
            catch (Exception ex)
            {
                return new _BaseResponse() { code = -1, msg = ex.Message };
            }

        }

        /// <summary>
        /// 股票信息-每日涨跌停价格
        /// </summary>
        /// <param name="ts_code"></param>
        /// <param name="trade_date"></param>
        /// <param name="start_date"></param>
        /// <param name="end_date"></param>
        public _BaseResponse stk_limit(string ts_code, string trade_date, string start_date, string end_date)
        {
            try
            {
                Dictionary<string, string> paramsList = new Dictionary<string, string>();
                paramsList.Add("ts_code", ts_code);
                paramsList.Add("trade_date", trade_date);
                paramsList.Add("start_date", start_date);
                paramsList.Add("end_date", end_date);
                StkLimitRequest request = new StkLimitRequest
                {
                    token = Token,
                    api_name = "stk_limit",
                    paramsList = paramsList
                };
                string json = JsonConvert.SerializeObject(request,
                    new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });
                return request.Request<_BaseResponse>(url, json);
            }
            catch (Exception ex)
            {
                return new _BaseResponse() { code = -1, msg = ex.Message };
            }

        }

        /// <summary>
        /// 股票信息-停复牌信息
        /// </summary>
        /// <param name="ts_code"></param>
        /// <param name="suspend_date"></param>
        /// <param name="resume_date"></param>
        public _BaseResponse suspend(string ts_code, string suspend_date, string resume_date)
        {
            try
            {
                Dictionary<string, string> paramsList = new Dictionary<string, string>();
                paramsList.Add("ts_code", ts_code);
                paramsList.Add("suspend_date", suspend_date);
                paramsList.Add("resume_date", resume_date);
                
                SuspendRequest request = new SuspendRequest
                {
                    token = Token,
                    api_name = "suspend",
                    paramsList = paramsList
                };
                string json = JsonConvert.SerializeObject(request,
                    new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });
                return request.Request<_BaseResponse>(url, json);
            }
            catch (Exception ex)
            {
                return new _BaseResponse() { code = -1, msg = ex.Message };
            }

        }
        #endregion

        #region 财务数据
        /// <summary>
        /// 财务信息-利润表
        /// </summary>
        /// <param name="ts_code"></param>
        /// <param name="ann_date"></param>
        /// <param name="start_date"></param>
        /// <param name="end_date"></param>
        /// <param name="period"></param>
        /// <param name="report_type"></param>
        /// <param name="comp_type"></param>
        public _BaseResponse income(string ts_code, string ann_date, string start_date, string end_date, string period, string report_type, string comp_type)
        {
            try
            {
                Dictionary<string, string> paramsList = new Dictionary<string, string>();
                paramsList.Add("ts_code", ts_code);
                paramsList.Add("ann_date", ann_date);
                paramsList.Add("start_date", start_date);
                paramsList.Add("end_date", end_date);
                paramsList.Add("period", period);
                paramsList.Add("report_type", report_type);
                paramsList.Add("comp_type", comp_type);

                IncomeRequest request = new IncomeRequest
                {
                    token = Token,
                    api_name = "income",
                    paramsList = paramsList
                };
                string json = JsonConvert.SerializeObject(request,
                    new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });
                return request.Request<_BaseResponse>(url, json);
            }
            catch (Exception ex)
            {
                return new _BaseResponse() { code = -1, msg = ex.Message };
            }

        }

        /// <summary>
        /// 财务信息-资产负债表
        /// </summary>
        /// <param name="ts_code"></param>
        /// <param name="ann_date"></param>
        /// <param name="start_date"></param>
        /// <param name="end_date"></param>
        /// <param name="period"></param>
        /// <param name="report_type"></param>
        /// <param name="comp_type"></param>
        public _BaseResponse balancesheet(string ts_code, string ann_date, string start_date, string end_date, string period, string report_type, string comp_type)
        {
            try
            {
                Dictionary<string, string> paramsList = new Dictionary<string, string>();
                paramsList.Add("ts_code", ts_code);
                paramsList.Add("ann_date", ann_date);
                paramsList.Add("start_date", start_date);
                paramsList.Add("end_date", end_date);
                paramsList.Add("period", period);
                paramsList.Add("report_type", report_type);
                paramsList.Add("comp_type", comp_type);

                BalancesheetRequest request = new BalancesheetRequest
                {
                    token = Token,
                    api_name = "balancesheet",
                    paramsList = paramsList
                };
                string json = JsonConvert.SerializeObject(request,
                    new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });
                return request.Request<_BaseResponse>(url, json);
            }
            catch (Exception ex)
            {
                return new _BaseResponse() { code = -1, msg = ex.Message };
            }

        }

        /// <summary>
        /// 财务信息-现金流量表
        /// </summary>
        /// <param name="ts_code"></param>
        /// <param name="ann_date"></param>
        /// <param name="start_date"></param>
        /// <param name="end_date"></param>
        /// <param name="period"></param>
        /// <param name="report_type"></param>
        /// <param name="comp_type"></param>
        public _BaseResponse cashflow(string ts_code, string ann_date, string start_date, string end_date, string period, string report_type, string comp_type)
        {
            try
            {
                Dictionary<string, string> paramsList = new Dictionary<string, string>();
                paramsList.Add("ts_code", ts_code);
                paramsList.Add("ann_date", ann_date);
                paramsList.Add("start_date", start_date);
                paramsList.Add("end_date", end_date);
                paramsList.Add("period", period);
                paramsList.Add("report_type", report_type);
                paramsList.Add("comp_type", comp_type);

                CashflowRequest request = new CashflowRequest
                {
                    token = Token,
                    api_name = "cashflow",
                    paramsList = paramsList
                };
                string json = JsonConvert.SerializeObject(request,
                    new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });
                return request.Request<_BaseResponse>(url, json);
            }
            catch (Exception ex)
            {
                return new _BaseResponse() { code = -1, msg = ex.Message };
            }

        }

        /// <summary>
        /// 财务信息-业绩预告
        /// </summary>
        /// <param name="ts_code"></param>
        /// <param name="ann_date"></param>
        /// <param name="start_date"></param>
        /// <param name="end_date"></param>
        /// <param name="period"></param>
        /// <param name="type"></param>
        public _BaseResponse forecast(string ts_code, string ann_date, string start_date, string end_date, string period, string type)
        {
            try
            {
                Dictionary<string, string> paramsList = new Dictionary<string, string>();
                paramsList.Add("ts_code", ts_code);
                paramsList.Add("ann_date", ann_date);
                paramsList.Add("start_date", start_date);
                paramsList.Add("end_date", end_date);
                paramsList.Add("period", period);
                paramsList.Add("type", type);

                ForecastRequest request = new ForecastRequest
                {
                    token = Token,
                    api_name = "forecast",
                    paramsList = paramsList
                };
                string json = JsonConvert.SerializeObject(request,
                    new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });
                return request.Request<_BaseResponse>(url, json);
            }
            catch (Exception ex)
            {
                return new _BaseResponse() { code = -1, msg = ex.Message };
            }

        }

        /// <summary>
        /// 财务信息-业绩快报
        /// </summary>
        /// <param name="ts_code"></param>
        /// <param name="ann_date"></param>
        /// <param name="start_date"></param>
        /// <param name="end_date"></param>
        /// <param name="period"></param>
        public _BaseResponse express(string ts_code, string ann_date, string start_date, string end_date, string period)
        {
            try
            {
                Dictionary<string, string> paramsList = new Dictionary<string, string>();
                paramsList.Add("ts_code", ts_code);
                paramsList.Add("ann_date", ann_date);
                paramsList.Add("start_date", start_date);
                paramsList.Add("end_date", end_date);
                paramsList.Add("period", period);

                ExpressRequest request = new ExpressRequest
                {
                    token = Token,
                    api_name = "express",
                    paramsList = paramsList
                };
                string json = JsonConvert.SerializeObject(request,
                    new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });
                return request.Request<_BaseResponse>(url, json);
            }
            catch (Exception ex)
            {
                return new _BaseResponse() { code = -1, msg = ex.Message };
            }

        }

        /// <summary>
        /// 财务信息-分红送股
        /// </summary>
        /// <param name="ts_code"></param>
        /// <param name="ann_date"></param>
        /// <param name="record_date"></param>
        /// <param name="ex_date"></param>
        /// <param name="imp_ann_date"></param>
        public _BaseResponse dividend(string ts_code, string ann_date, string record_date, string ex_date, string imp_ann_date)
        {
            try
            {
                Dictionary<string, string> paramsList = new Dictionary<string, string>();
                paramsList.Add("ts_code", ts_code);
                paramsList.Add("ann_date", ann_date);
                paramsList.Add("record_date", record_date);
                paramsList.Add("ex_date", ex_date);
                paramsList.Add("imp_ann_date", imp_ann_date);

                DividendRequest request = new DividendRequest
                {
                    token = Token,
                    api_name = "dividend",
                    paramsList = paramsList
                };
                string json = JsonConvert.SerializeObject(request,
                    new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });
                return request.Request<_BaseResponse>(url, json);
            }
            catch (Exception ex)
            {
                return new _BaseResponse() { code = -1, msg = ex.Message };
            }

        }

        /// <summary>
        /// 财务信息-财务指标数据
        /// </summary>
        /// <param name="ts_code"></param>
        /// <param name="ann_date"></param>
        /// <param name="start_date"></param>
        /// <param name="end_date"></param>
        /// <param name="period"></param>
        public _BaseResponse fina_indicator(string ts_code, string ann_date, string start_date, string end_date, string period)
        {
            try
            {
                Dictionary<string, string> paramsList = new Dictionary<string, string>();
                paramsList.Add("ts_code", ts_code);
                paramsList.Add("ann_date", ann_date);
                paramsList.Add("start_date", start_date);
                paramsList.Add("end_date", end_date);
                paramsList.Add("period", period);

                FinaIndicatorRequest request = new FinaIndicatorRequest
                {
                    token = Token,
                    api_name = "fina_indicator",
                    paramsList = paramsList
                };
                string json = JsonConvert.SerializeObject(request,
                    new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });
                return request.Request<_BaseResponse>(url, json);
            }
            catch (Exception ex)
            {
                return new _BaseResponse() { code = -1, msg = ex.Message };
            }

        }

        /// <summary>
        /// 财务信息-财务审计意见
        /// </summary>
        /// <param name="ts_code"></param>
        /// <param name="ann_date"></param>
        /// <param name="start_date"></param>
        /// <param name="end_date"></param>
        /// <param name="period"></param>
        public _BaseResponse fina_audit(string ts_code, string ann_date, string start_date, string end_date, string period)
        {
            try
            {
                Dictionary<string, string> paramsList = new Dictionary<string, string>();
                paramsList.Add("ts_code", ts_code);
                paramsList.Add("ann_date", ann_date);
                paramsList.Add("start_date", start_date);
                paramsList.Add("end_date", end_date);
                paramsList.Add("period", period);

                FinaAuditRequest request = new FinaAuditRequest
                {
                    token = Token,
                    api_name = "fina_audit",
                    paramsList = paramsList
                };
                string json = JsonConvert.SerializeObject(request,
                    new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });
                return request.Request<_BaseResponse>(url, json);
            }
            catch (Exception ex)
            {
                return new _BaseResponse() { code = -1, msg = ex.Message };
            }

        }

        /// <summary>
        /// 财务信息-主营业务构成
        /// </summary>
        /// <param name="ts_code"></param>
        /// <param name="period"></param>
        /// <param name="type"></param>
        /// <param name="start_date"></param>
        /// <param name="end_date"></param>
        public _BaseResponse fina_mainbz(string ts_code, string period, string type, string start_date, string end_date)
        {
            try
            {
                Dictionary<string, string> paramsList = new Dictionary<string, string>();
                paramsList.Add("ts_code", ts_code);
                paramsList.Add("period", period);
                paramsList.Add("type", type);
                paramsList.Add("start_date", start_date);
                paramsList.Add("end_date", end_date);

                FinaMainbzRequest request = new FinaMainbzRequest
                {
                    token = Token,
                    api_name = "fina_mainbz",
                    paramsList = paramsList
                };
                string json = JsonConvert.SerializeObject(request,
                    new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });
                return request.Request<_BaseResponse>(url, json);
            }
            catch (Exception ex)
            {
                return new _BaseResponse() { code = -1, msg = ex.Message };
            }

        }

        /// <summary>
        /// 财务信息-财报披露计划
        /// </summary>
        /// <param name="ts_code"></param>
        /// <param name="end_date"></param>
        /// <param name="pre_date"></param>
        /// <param name="actual_date"></param>
        public _BaseResponse disclosure_date(string ts_code, string end_date, string pre_date, string actual_date)
        {
            try
            {
                Dictionary<string, string> paramsList = new Dictionary<string, string>();
                paramsList.Add("ts_code", ts_code);
                paramsList.Add("end_date", end_date);
                paramsList.Add("pre_date", pre_date);
                paramsList.Add("actual_date", actual_date);

                DisclosureDateRequest request = new DisclosureDateRequest
                {
                    token = Token,
                    api_name = "disclosure_date",
                    paramsList = paramsList
                };
                string json = JsonConvert.SerializeObject(request,
                    new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });
                return request.Request<_BaseResponse>(url, json);
            }
            catch (Exception ex)
            {
                return new _BaseResponse() { code = -1, msg = ex.Message };
            }

        }
        #endregion

        #region 市场参考
        /// <summary>
        /// 市场参考-沪深港通资金流向
        /// </summary>
        /// <param name="trade_date"></param>
        /// <param name="start_date"></param>
        /// <param name="end_date"></param>
        public _BaseResponse moneyflow_hsgt(string trade_date, string start_date, string end_date)
        {
            try
            {
                Dictionary<string, string> paramsList = new Dictionary<string, string>();
                paramsList.Add("trade_date", trade_date);
                paramsList.Add("start_date", start_date);
                paramsList.Add("end_date", end_date);

                MoneyflowHsgtRequest request = new MoneyflowHsgtRequest
                {
                    token = Token,
                    api_name = "moneyflow_hsgt",
                    paramsList = paramsList
                };
                string json = JsonConvert.SerializeObject(request,
                    new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });
                return request.Request<_BaseResponse>(url, json);
            }
            catch (Exception ex)
            {
                return new _BaseResponse() { code = -1, msg = ex.Message };
            }

        }

        /// <summary>
        /// 市场参考-沪深股通十大成交股
        /// </summary>
        /// <param name="ts_code"></param>
        /// <param name="trade_date"></param>
        /// <param name="start_date"></param>
        /// <param name="end_date"></param>
        /// <param name="market_type"></param>

        public _BaseResponse hsgt_top10(string ts_code,string trade_date, string start_date, string end_date,string market_type)
        {
            try
            {
                Dictionary<string, string> paramsList = new Dictionary<string, string>();
                paramsList.Add("ts_code", ts_code);
                paramsList.Add("trade_date", trade_date);
                paramsList.Add("start_date", start_date);
                paramsList.Add("end_date", end_date);
                paramsList.Add("market_type", market_type);

                HsgtTop10Request request = new HsgtTop10Request
                {
                    token = Token,
                    api_name = "hsgt_top10",
                    paramsList = paramsList
                };
                string json = JsonConvert.SerializeObject(request,
                    new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });
                return request.Request<_BaseResponse>(url, json);
            }
            catch (Exception ex)
            {
                return new _BaseResponse() { code = -1, msg = ex.Message };
            }

        }

        /// <summary>
        /// 市场参考-港股通十大成交股
        /// </summary>
        /// <param name="ts_code"></param>
        /// <param name="trade_date"></param>
        /// <param name="start_date"></param>
        /// <param name="end_date"></param>
        /// <param name="market_type"></param>

        public _BaseResponse ggt_top10(string ts_code, string trade_date, string start_date, string end_date, string market_type)
        {
            try
            {
                Dictionary<string, string> paramsList = new Dictionary<string, string>();
                paramsList.Add("ts_code", ts_code);
                paramsList.Add("trade_date", trade_date);
                paramsList.Add("start_date", start_date);
                paramsList.Add("end_date", end_date);
                paramsList.Add("market_type", market_type);

                GgtTop10Request request = new GgtTop10Request
                {
                    token = Token,
                    api_name = "ggt_top10",
                    paramsList = paramsList
                };
                string json = JsonConvert.SerializeObject(request,
                    new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });
                return request.Request<_BaseResponse>(url, json);
            }
            catch (Exception ex)
            {
                return new _BaseResponse() { code = -1, msg = ex.Message };
            }

        }

        /// <summary>
        /// 市场参考-融资融券交易汇总
        /// </summary>
        /// <param name="trade_date"></param>
        /// <param name="exchange_id"></param>
        /// <param name="start_date"></param>
        /// <param name="end_date"></param>

        public _BaseResponse margin(string trade_date, string exchange_id, string start_date, string end_date)
        {
            try
            {
                Dictionary<string, string> paramsList = new Dictionary<string, string>();
                paramsList.Add("trade_date", trade_date);
                paramsList.Add("exchange_id", exchange_id);
                paramsList.Add("start_date", start_date);
                paramsList.Add("end_date", end_date);

                MarginRequest request = new MarginRequest
                {
                    token = Token,
                    api_name = "margin",
                    paramsList = paramsList
                };
                string json = JsonConvert.SerializeObject(request,
                    new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });
                return request.Request<_BaseResponse>(url, json);
            }
            catch (Exception ex)
            {
                return new _BaseResponse() { code = -1, msg = ex.Message };
            }

        }

        /// <summary>
        /// 市场参考-融资融券交易明细
        /// </summary>
        /// <param name="trade_date"></param>
        /// <param name="ts_code"></param>
        /// <param name="start_date"></param>
        /// <param name="end_date"></param>

        public _BaseResponse margin_detail(string trade_date, string ts_code, string start_date, string end_date)
        {
            try
            {
                Dictionary<string, string> paramsList = new Dictionary<string, string>();
                paramsList.Add("trade_date", trade_date);
                paramsList.Add("ts_code", ts_code);
                paramsList.Add("start_date", start_date);
                paramsList.Add("end_date", end_date);

                MarginDetailRequest request = new MarginDetailRequest
                {
                    token = Token,
                    api_name = "margin_detail",
                    paramsList = paramsList
                };
                string json = JsonConvert.SerializeObject(request,
                    new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });
                return request.Request<_BaseResponse>(url, json);
            }
            catch (Exception ex)
            {
                return new _BaseResponse() { code = -1, msg = ex.Message };
            }

        }

        /// <summary>
        /// 市场参考-前十大股东
        /// </summary>
        /// <param name="ts_code"></param>
        /// <param name="period"></param>
        /// <param name="ann_date"></param>
        /// <param name="start_date"></param>
        /// <param name="end_date"></param>

        public _BaseResponse top10_holders(string ts_code, string period, string ann_date, string start_date, string end_date)
        {
            try
            {
                Dictionary<string, string> paramsList = new Dictionary<string, string>();
                paramsList.Add("ts_code", ts_code);
                paramsList.Add("period", period);
                paramsList.Add("ann_date", ann_date);
                paramsList.Add("start_date", start_date);
                paramsList.Add("end_date", end_date);

                Top10HoldersRequest request = new Top10HoldersRequest
                {
                    token = Token,
                    api_name = "top10_holders",
                    paramsList = paramsList
                };
                string json = JsonConvert.SerializeObject(request,
                    new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });
                return request.Request<_BaseResponse>(url, json);
            }
            catch (Exception ex)
            {
                return new _BaseResponse() { code = -1, msg = ex.Message };
            }

        }

        /// <summary>
        /// 市场参考-前十大流通股东
        /// </summary>
        /// <param name="ts_code"></param>
        /// <param name="period"></param>
        /// <param name="ann_date"></param>
        /// <param name="start_date"></param>
        /// <param name="end_date"></param>

        public _BaseResponse top10_floatholders(string ts_code, string period, string ann_date, string start_date, string end_date)
        {
            try
            {
                Dictionary<string, string> paramsList = new Dictionary<string, string>();
                paramsList.Add("ts_code", ts_code);
                paramsList.Add("period", period);
                paramsList.Add("ann_date", ann_date);
                paramsList.Add("start_date", start_date);
                paramsList.Add("end_date", end_date);

                Top10FloatholdersRequest request = new Top10FloatholdersRequest
                {
                    token = Token,
                    api_name = "top10_floatholders",
                    paramsList = paramsList
                };
                string json = JsonConvert.SerializeObject(request,
                    new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });
                return request.Request<_BaseResponse>(url, json);
            }
            catch (Exception ex)
            {
                return new _BaseResponse() { code = -1, msg = ex.Message };
            }

        }

        /// <summary>
        /// 市场参考-龙虎榜每日明细
        /// </summary>
        /// <param name="trade_date"></param>
        /// <param name="ts_code"></param>

        public _BaseResponse top_list(string trade_date, string ts_code)
        {
            try
            {
                Dictionary<string, string> paramsList = new Dictionary<string, string>();
                paramsList.Add("trade_date", trade_date);
                paramsList.Add("ts_code", ts_code);

                Top10FloatholdersRequest request = new Top10FloatholdersRequest
                {
                    token = Token,
                    api_name = "top_list",
                    paramsList = paramsList
                };
                string json = JsonConvert.SerializeObject(request,
                    new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });
                return request.Request<_BaseResponse>(url, json);
            }
            catch (Exception ex)
            {
                return new _BaseResponse() { code = -1, msg = ex.Message };
            }

        }

        /// <summary>
        /// 市场参考-龙虎榜机构明细
        /// </summary>
        /// <param name="trade_date"></param>
        /// <param name="ts_code"></param>

        public _BaseResponse top_inst(string trade_date, string ts_code)
        {
            try
            {
                Dictionary<string, string> paramsList = new Dictionary<string, string>();
                paramsList.Add("trade_date", trade_date);
                paramsList.Add("ts_code", ts_code);

                TopInstRequest request = new TopInstRequest
                {
                    token = Token,
                    api_name = "top_inst",
                    paramsList = paramsList
                };
                string json = JsonConvert.SerializeObject(request,
                    new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });
                return request.Request<_BaseResponse>(url, json);
            }
            catch (Exception ex)
            {
                return new _BaseResponse() { code = -1, msg = ex.Message };
            }

        }

        /// <summary>
        /// 市场参考-股权质押统计数据
        /// </summary>
        /// <param name="ts_code"></param>

        public _BaseResponse pledge_stat(string ts_code)
        {
            try
            {
                Dictionary<string, string> paramsList = new Dictionary<string, string>();
                paramsList.Add("ts_code", ts_code);

                PledgeStatRequest request = new PledgeStatRequest
                {
                    token = Token,
                    api_name = "pledge_stat",
                    paramsList = paramsList
                };
                string json = JsonConvert.SerializeObject(request,
                    new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });
                return request.Request<_BaseResponse>(url, json);
            }
            catch (Exception ex)
            {
                return new _BaseResponse() { code = -1, msg = ex.Message };
            }

        }

        /// <summary>
        /// 市场参考-股权质押明细
        /// </summary>
        /// <param name="ts_code"></param>

        public _BaseResponse pledge_detail(string ts_code)
        {
            try
            {
                Dictionary<string, string> paramsList = new Dictionary<string, string>();
                paramsList.Add("ts_code", ts_code);

                PledgeDetailRequest request = new PledgeDetailRequest
                {
                    token = Token,
                    api_name = "pledge_detail",
                    paramsList = paramsList
                };
                string json = JsonConvert.SerializeObject(request,
                    new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });
                return request.Request<_BaseResponse>(url, json);
            }
            catch (Exception ex)
            {
                return new _BaseResponse() { code = -1, msg = ex.Message };
            }

        }

        /// <summary>
        /// 市场参考-股票回购
        /// </summary>
        /// <param name="ann_date"></param>
        /// <param name="start_date"></param>
        /// <param name="end_date"></param>

        public _BaseResponse repurchase(string ann_date,string start_date, string end_date)
        {
            try
            {
                Dictionary<string, string> paramsList = new Dictionary<string, string>();
                paramsList.Add("ann_date", ann_date);
                paramsList.Add("start_date", start_date);
                paramsList.Add("end_date", end_date);

                RepurchaseRequest request = new RepurchaseRequest
                {
                    token = Token,
                    api_name = "repurchase",
                    paramsList = paramsList
                };
                string json = JsonConvert.SerializeObject(request,
                    new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });
                return request.Request<_BaseResponse>(url, json);
            }
            catch (Exception ex)
            {
                return new _BaseResponse() { code = -1, msg = ex.Message };
            }

        }

        /// <summary>
        /// 市场参考-概念股分类
        /// </summary>
        /// <param name="src"></param>
        public _BaseResponse concept(string src)
        {
            try
            {
                Dictionary<string, string> paramsList = new Dictionary<string, string>();
                paramsList.Add("src", src);

                ConceptRequest request = new ConceptRequest
                {
                    token = Token,
                    api_name = "concept",
                    paramsList = paramsList
                };
                string json = JsonConvert.SerializeObject(request,
                    new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });
                return request.Request<_BaseResponse>(url, json);
            }
            catch (Exception ex)
            {
                return new _BaseResponse() { code = -1, msg = ex.Message };
            }

        }

        /// <summary>
        /// 市场参考-概念股列表
        /// </summary>
        /// <param name="id"></param>
        /// <param name="ts_code"></param>
        public _BaseResponse concept_detail(string id,string ts_code)
        {
            try
            {
                Dictionary<string, string> paramsList = new Dictionary<string, string>();
                paramsList.Add("id", id);
                paramsList.Add("ts_code", ts_code);

                ConceptDetailRequest request = new ConceptDetailRequest
                {
                    token = Token,
                    api_name = "concept_detail",
                    paramsList = paramsList
                };
                string json = JsonConvert.SerializeObject(request,
                    new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });
                return request.Request<_BaseResponse>(url, json);
            }
            catch (Exception ex)
            {
                return new _BaseResponse() { code = -1, msg = ex.Message };
            }

        }

        /// <summary>
        /// 市场参考-限售股解禁
        /// </summary>
        /// <param name="ts_code"></param>
        /// <param name="ann_date"></param>
        /// <param name="float_date"></param>
        /// <param name="start_date"></param>
        /// <param name="end_date"></param>
        public _BaseResponse share_float(string ts_code, string ann_date, string float_date, string start_date, string end_date)
        {
            try
            {
                Dictionary<string, string> paramsList = new Dictionary<string, string>();
                paramsList.Add("ts_code", ts_code);
                paramsList.Add("ann_date", ann_date);
                paramsList.Add("float_date", float_date);
                paramsList.Add("start_date", start_date);
                paramsList.Add("end_date", end_date);

                ShareFloatRequest request = new ShareFloatRequest
                {
                    token = Token,
                    api_name = "share_float",
                    paramsList = paramsList
                };
                string json = JsonConvert.SerializeObject(request,
                    new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });
                return request.Request<_BaseResponse>(url, json);
            }
            catch (Exception ex)
            {
                return new _BaseResponse() { code = -1, msg = ex.Message };
            }

        }


        /// <summary>
        /// 市场参考-大宗交易
        /// </summary>
        /// <param name="ts_code"></param>
        /// <param name="trade_date"></param>
        /// <param name="start_date"></param>
        /// <param name="end_date"></param>
        public _BaseResponse block_trade(string ts_code, string trade_date, string start_date, string end_date)
        {
            try
            {
                Dictionary<string, string> paramsList = new Dictionary<string, string>();
                paramsList.Add("ts_code", ts_code);
                paramsList.Add("trade_date", trade_date);
                paramsList.Add("start_date", start_date);
                paramsList.Add("end_date", end_date);

                BlockTradeRequest request = new BlockTradeRequest
                {
                    token = Token,
                    api_name = "block_trade",
                    paramsList = paramsList
                };
                string json = JsonConvert.SerializeObject(request,
                    new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });
                return request.Request<_BaseResponse>(url, json);
            }
            catch (Exception ex)
            {
                return new _BaseResponse() { code = -1, msg = ex.Message };
            }

        }

        /// <summary>
        /// 市场参考-股票账户开户数据
        /// </summary>
        /// <param name="date"></param>
        /// <param name="start_date"></param>
        /// <param name="end_date"></param>
        public _BaseResponse stk_account(string date,  string start_date, string end_date)
        {
            try
            {
                Dictionary<string, string> paramsList = new Dictionary<string, string>();
                paramsList.Add("date", date);
                paramsList.Add("start_date", start_date);
                paramsList.Add("end_date", end_date);

                StkAccountRequest request = new StkAccountRequest
                {
                    token = Token,
                    api_name = "stk_account",
                    paramsList = paramsList
                };
                string json = JsonConvert.SerializeObject(request,
                    new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });
                return request.Request<_BaseResponse>(url, json);
            }
            catch (Exception ex)
            {
                return new _BaseResponse() { code = -1, msg = ex.Message };
            }

        }

        /// <summary>
        /// 市场参考-股票账户开户数据（旧）
        /// </summary>
        /// <param name="start_date"></param>
        /// <param name="end_date"></param>
        public _BaseResponse stk_account_old(string start_date, string end_date)
        {
            try
            {
                Dictionary<string, string> paramsList = new Dictionary<string, string>();
                paramsList.Add("start_date", start_date);
                paramsList.Add("end_date", end_date);

                StkAccountOldRequest request = new StkAccountOldRequest
                {
                    token = Token,
                    api_name = "stk_account_old",
                    paramsList = paramsList
                };
                string json = JsonConvert.SerializeObject(request,
                    new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });
                return request.Request<_BaseResponse>(url, json);
            }
            catch (Exception ex)
            {
                return new _BaseResponse() { code = -1, msg = ex.Message };
            }

        }

        /// <summary>
        /// 市场参考-股东人数
        /// </summary>
        /// <param name="ts_code"></param>
        /// <param name="enddate"></param>
        /// <param name="start_date"></param>
        /// <param name="end_date"></param>
        public _BaseResponse stk_holdernumber(string ts_code, string enddate, string start_date, string end_date)
        {
            try
            {
                Dictionary<string, string> paramsList = new Dictionary<string, string>();
                paramsList.Add("ts_code", ts_code);
                paramsList.Add("enddate", enddate);
                paramsList.Add("start_date", start_date);
                paramsList.Add("end_date", end_date);

                StkHoldernumberRequest request = new StkHoldernumberRequest
                {
                    token = Token,
                    api_name = "stk_holdernumber",
                    paramsList = paramsList
                };
                string json = JsonConvert.SerializeObject(request,
                    new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });
                return request.Request<_BaseResponse>(url, json);
            }
            catch (Exception ex)
            {
                return new _BaseResponse() { code = -1, msg = ex.Message };
            }

        }

        /// <summary>
        /// 市场参考-股东增减持
        /// </summary>
        /// <param name="ts_code"></param>
        /// <param name="ann_date"></param>
        /// <param name="start_date"></param>
        /// <param name="end_date"></param>
        /// <param name="trade_type"></param>
        /// <param name="holder_type"></param>
        public _BaseResponse stk_holdertrade(string ts_code, string ann_date, string start_date, string end_date, string trade_type, string holder_type)
        {
            try
            {
                Dictionary<string, string> paramsList = new Dictionary<string, string>();
                paramsList.Add("ts_code", ts_code);
                paramsList.Add("ann_date", ann_date);
                paramsList.Add("start_date", start_date);
                paramsList.Add("end_date", end_date);
                paramsList.Add("trade_type", trade_type);
                paramsList.Add("holder_type", holder_type);

                StkHoldertradeRequest request = new StkHoldertradeRequest
                {
                    token = Token,
                    api_name = "stk_holdertrade",
                    paramsList = paramsList
                };
                string json = JsonConvert.SerializeObject(request,
                    new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });
                return request.Request<_BaseResponse>(url, json);
            }
            catch (Exception ex)
            {
                return new _BaseResponse() { code = -1, msg = ex.Message };
            }

        }
        #endregion

        #region 指数
        /// <summary>
        /// 指数-指数基本信息
        /// </summary>
        /// <param name="market"></param>
        /// <param name="publisher"></param>
        /// <param name="category"></param>
        public _BaseResponse index_basic(string market, string publisher, string category)
        {
            try
            {
                Dictionary<string, string> paramsList = new Dictionary<string, string>();
                paramsList.Add("market", market);
                paramsList.Add("publisher", publisher);
                paramsList.Add("category", category);

                IndexBasicRequest request = new IndexBasicRequest
                {
                    token = Token,
                    api_name = "index_basic",
                    paramsList = paramsList
                };
                string json = JsonConvert.SerializeObject(request,
                    new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });
                return request.Request<_BaseResponse>(url, json);
            }
            catch (Exception ex)
            {
                return new _BaseResponse() { code = -1, msg = ex.Message };
            }

        }

        /// <summary>
        /// 指数-指数成分和权重
        /// </summary>
        /// <param name="index_code"></param>
        /// <param name="trade_date"></param>
        /// <param name="start_date"></param>
        /// <param name="end_date"></param>
        public _BaseResponse index_weight(string index_code, string trade_date, string start_date, string end_date)
        {
            try
            {
                Dictionary<string, string> paramsList = new Dictionary<string, string>();
                paramsList.Add("index_code", index_code);
                paramsList.Add("trade_date", trade_date);
                paramsList.Add("start_date", start_date);
                paramsList.Add("end_date", end_date);

                IndexWeightRequest request = new IndexWeightRequest
                {
                    token = Token,
                    api_name = "index_weight",
                    paramsList = paramsList
                };
                string json = JsonConvert.SerializeObject(request,
                    new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });
                return request.Request<_BaseResponse>(url, json);
            }
            catch (Exception ex)
            {
                return new _BaseResponse() { code = -1, msg = ex.Message };
            }

        }

        /// <summary>
        /// 指数-大盘指数每日指标
        /// </summary>
        /// <param name="trade_date"></param>
        /// <param name="ts_code"></param>
        /// <param name="start_date"></param>
        /// <param name="end_date"></param>
        public _BaseResponse index_dailybasic(string trade_date, string ts_code, string start_date, string end_date)
        {
            try
            {
                Dictionary<string, string> paramsList = new Dictionary<string, string>();
                paramsList.Add("trade_date", trade_date);
                paramsList.Add("ts_code", ts_code);
                paramsList.Add("start_date", start_date);
                paramsList.Add("end_date", end_date);

                IndexDailybasicRequest request = new IndexDailybasicRequest
                {
                    token = Token,
                    api_name = "index_dailybasic",
                    paramsList = paramsList
                };
                string json = JsonConvert.SerializeObject(request,
                    new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });
                return request.Request<_BaseResponse>(url, json);
            }
            catch (Exception ex)
            {
                return new _BaseResponse() { code = -1, msg = ex.Message };
            }

        }

        /// <summary>
        /// 指数-申万行业分类
        /// </summary>
        /// <param name="index_code"></param>
        /// <param name="level"></param>
        /// <param name="src"></param>
        public _BaseResponse index_classify(string index_code, string level, string src)
        {
            try
            {
                Dictionary<string, string> paramsList = new Dictionary<string, string>();
                paramsList.Add("index_code", index_code);
                paramsList.Add("level", level);
                paramsList.Add("src", src);

                IndexClassifyRequest request = new IndexClassifyRequest
                {
                    token = Token,
                    api_name = "index_classify",
                    paramsList = paramsList
                };
                string json = JsonConvert.SerializeObject(request,
                    new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });
                return request.Request<_BaseResponse>(url, json);
            }
            catch (Exception ex)
            {
                return new _BaseResponse() { code = -1, msg = ex.Message };
            }

        }

        /// <summary>
        /// 指数-申万行业成分构成
        /// </summary>
        /// <param name="index_code"></param>
        /// <param name="ts_code"></param>
        /// <param name="is_new"></param>
        public _BaseResponse index_member(string index_code, string level, string is_new)
        {
            try
            {
                Dictionary<string, string> paramsList = new Dictionary<string, string>();
                paramsList.Add("index_code", index_code);
                paramsList.Add("level", level);
                paramsList.Add("is_new", is_new);

                IndexMemberRequest request = new IndexMemberRequest
                {
                    token = Token,
                    api_name = "index_member",
                    paramsList = paramsList
                };
                string json = JsonConvert.SerializeObject(request,
                    new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });
                return request.Request<_BaseResponse>(url, json);
            }
            catch (Exception ex)
            {
                return new _BaseResponse() { code = -1, msg = ex.Message };
            }

        }
        #endregion

        #region 基金
        /// <summary>
        /// 基金-公募基金列表
        /// </summary>
        /// <param name="market"></param>
        public _BaseResponse fund_basic(string market)
        {
            try
            {
                Dictionary<string, string> paramsList = new Dictionary<string, string>();
                paramsList.Add("market", market);

                FundBasicRequest request = new FundBasicRequest
                {
                    token = Token,
                    api_name = "fund_basic",
                    paramsList = paramsList
                };
                string json = JsonConvert.SerializeObject(request,
                    new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });
                return request.Request<_BaseResponse>(url, json);
            }
            catch (Exception ex)
            {
                return new _BaseResponse() { code = -1, msg = ex.Message };
            }

        }

        /// <summary>
        /// 基金-公募基金列表
        /// </summary>
        public _BaseResponse fund_company()
        {
            try
            {
                Dictionary<string, string> paramsList = new Dictionary<string, string>();

                FundCompanyRequest request = new FundCompanyRequest
                {
                    token = Token,
                    api_name = "fund_company",
                    paramsList = paramsList
                };
                string json = JsonConvert.SerializeObject(request,
                    new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });
                return request.Request<_BaseResponse>(url, json);
            }
            catch (Exception ex)
            {
                return new _BaseResponse() { code = -1, msg = ex.Message };
            }

        }

        /// <summary>
        /// 基金-公募基金列表
        /// </summary>
        /// <param name="market"></param>
        /// <param name="end_date"></param>
        public _BaseResponse fund_nav(string ts_code,string end_date)
        {
            try
            {
                Dictionary<string, string> paramsList = new Dictionary<string, string>();
                paramsList.Add("ts_code", ts_code);
                paramsList.Add("end_date", end_date);

                FundNavRequest request = new FundNavRequest
                {
                    token = Token,
                    api_name = "fund_nav",
                    paramsList = paramsList
                };
                string json = JsonConvert.SerializeObject(request,
                    new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });
                return request.Request<_BaseResponse>(url, json);
            }
            catch (Exception ex)
            {
                return new _BaseResponse() { code = -1, msg = ex.Message };
            }

        }

        /// <summary>
        /// 基金-公募基金分红
        /// </summary>
        /// <param name="ann_date"></param>
        /// <param name="ex_date"></param>
        /// <param name="pay_date"></param>
        /// <param name="ts_code"></param>
        public _BaseResponse fund_div(string ann_date, string ex_date,string pay_date, string ts_code)
        {
            try
            {
                Dictionary<string, string> paramsList = new Dictionary<string, string>();
                paramsList.Add("ann_date", ann_date);
                paramsList.Add("ex_date", ex_date);
                paramsList.Add("pay_date", pay_date);
                paramsList.Add("ts_code", ts_code);

                FundDivRequest request = new FundDivRequest
                {
                    token = Token,
                    api_name = "fund_div",
                    paramsList = paramsList
                };
                string json = JsonConvert.SerializeObject(request,
                    new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });
                return request.Request<_BaseResponse>(url, json);
            }
            catch (Exception ex)
            {
                return new _BaseResponse() { code = -1, msg = ex.Message };
            }

        }

        /// <summary>
        /// 基金-公募基金持仓数据
        /// </summary>
        /// <param name="ts_code"></param>
        public _BaseResponse fund_portfolio(string ts_code)
        {
            try
            {
                Dictionary<string, string> paramsList = new Dictionary<string, string>();
                paramsList.Add("ts_code", ts_code);

                FundPortfolioRequest request = new FundPortfolioRequest
                {
                    token = Token,
                    api_name = "fund_portfolio",
                    paramsList = paramsList
                };
                string json = JsonConvert.SerializeObject(request,
                    new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });
                return request.Request<_BaseResponse>(url, json);
            }
            catch (Exception ex)
            {
                return new _BaseResponse() { code = -1, msg = ex.Message };
            }

        }

        /// <summary>
        /// 基金-场内基金日线行情
        /// </summary>
        /// <param name="ts_code"></param>
        /// <param name="trade_date"></param>
        /// <param name="start_date"></param>
        /// <param name="end_date"></param>
        public _BaseResponse fund_daily(string ts_code,string trade_date,string start_date,string end_date)
        {
            try
            {
                Dictionary<string, string> paramsList = new Dictionary<string, string>();
                paramsList.Add("ts_code", ts_code);
                paramsList.Add("trade_date", trade_date);
                paramsList.Add("start_date", start_date);
                paramsList.Add("end_date", end_date);

                BarRequest request = new BarRequest
                {
                    token = Token,
                    api_name = "fund_daily",
                    paramsList = paramsList
                };
                string json = JsonConvert.SerializeObject(request,
                    new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });
                return request.Request<_BaseResponse>(url, json);
            }
            catch (Exception ex)
            {
                return new _BaseResponse() { code = -1, msg = ex.Message };
            }

        }
        #endregion

        #region 期货
        /// <summary>
        /// 期货-期货合约信息表
        /// </summary>
        /// <param name="exchange"></param>
        /// <param name="fut_type"></param>
        public _BaseResponse fut_basic(string exchange, string fut_type)
        {
            try
            {
                Dictionary<string, string> paramsList = new Dictionary<string, string>();
                paramsList.Add("exchange", exchange);
                paramsList.Add("fut_type", fut_type);

                FutBasicRequest request = new FutBasicRequest
                {
                    token = Token,
                    api_name = "fut_basic",
                    paramsList = paramsList
                };
                string json = JsonConvert.SerializeObject(request,
                    new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });
                return request.Request<_BaseResponse>(url, json);
            }
            catch (Exception ex)
            {
                return new _BaseResponse() { code = -1, msg = ex.Message };
            }

        }

        /// <summary>
        /// 期货-期货日线行情
        /// </summary>
        /// <param name="trade_date"></param>
        /// <param name="ts_code"></param>
        /// <param name="exchange"></param>
        /// <param name="start_date"></param>
        /// <param name="end_date"></param>
        public _BaseResponse fut_daily(string trade_date, string ts_code, string exchange, string start_date, string end_date)
        {
            try
            {
                Dictionary<string, string> paramsList = new Dictionary<string, string>();
                paramsList.Add("trade_date", trade_date);
                paramsList.Add("ts_code", ts_code);
                paramsList.Add("exchange", exchange);
                paramsList.Add("start_date", start_date);
                paramsList.Add("end_date", end_date);
                
                FutDailyRequest request = new FutDailyRequest
                {
                    token = Token,
                    api_name = "fut_daily",
                    paramsList = paramsList
                };
                string json = JsonConvert.SerializeObject(request,
                    new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });
                return request.Request<_BaseResponse>(url, json);
            }
            catch (Exception ex)
            {
                return new _BaseResponse() { code = -1, msg = ex.Message };
            }

        }

        /// <summary>
        /// 期货-每日成交持仓排名
        /// </summary>
        /// <param name="trade_date"></param>
        /// <param name="symbol"></param>
        /// <param name="exchange"></param>
        /// <param name="start_date"></param>
        /// <param name="end_date"></param>
        public _BaseResponse fut_holding(string trade_date, string symbol,  string start_date, string end_date, string exchange)
        {
            try
            {
                Dictionary<string, string> paramsList = new Dictionary<string, string>();
                paramsList.Add("trade_date", trade_date);
                paramsList.Add("symbol", symbol);
                paramsList.Add("start_date", start_date);
                paramsList.Add("end_date", end_date);
                paramsList.Add("exchange", exchange);

                FutHoldingRequest request = new FutHoldingRequest
                {
                    token = Token,
                    api_name = "fut_holding",
                    paramsList = paramsList
                };
                string json = JsonConvert.SerializeObject(request,
                    new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });
                return request.Request<_BaseResponse>(url, json);
            }
            catch (Exception ex)
            {
                return new _BaseResponse() { code = -1, msg = ex.Message };
            }

        }

        /// <summary>
        /// 期货-仓单日报
        /// </summary>
        /// <param name="trade_date"></param>
        /// <param name="symbol"></param>
        /// <param name="exchange"></param>
        /// <param name="start_date"></param>
        /// <param name="end_date"></param>
        public _BaseResponse fut_wsr(string trade_date, string symbol, string start_date, string end_date, string exchange)
        {
            try
            {
                Dictionary<string, string> paramsList = new Dictionary<string, string>();
                paramsList.Add("trade_date", trade_date);
                paramsList.Add("symbol", symbol);
                paramsList.Add("start_date", start_date);
                paramsList.Add("end_date", end_date);
                paramsList.Add("exchange", exchange);

                FutWsrRequest request = new FutWsrRequest
                {
                    token = Token,
                    api_name = "fut_wsr",
                    paramsList = paramsList
                };
                string json = JsonConvert.SerializeObject(request,
                    new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });
                return request.Request<_BaseResponse>(url, json);
            }
            catch (Exception ex)
            {
                return new _BaseResponse() { code = -1, msg = ex.Message };
            }
        }

        /// <summary>
        /// 期货-仓单日报
        /// </summary>
        /// <param name="trade_date"></param>
        /// <param name="ts_code"></param>
        /// <param name="exchange"></param>
        /// <param name="start_date"></param>
        /// <param name="end_date"></param>
        public _BaseResponse fut_settle(string trade_date, string ts_code, string start_date, string end_date, string exchange)
        {
            try
            {
                Dictionary<string, string> paramsList = new Dictionary<string, string>();
                paramsList.Add("trade_date", trade_date);
                paramsList.Add("ts_code", ts_code);
                paramsList.Add("start_date", start_date);
                paramsList.Add("end_date", end_date);
                paramsList.Add("exchange", exchange);

                FutSettleRequest request = new FutSettleRequest
                {
                    token = Token,
                    api_name = "fut_settle",
                    paramsList = paramsList
                };
                string json = JsonConvert.SerializeObject(request,
                    new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });
                return request.Request<_BaseResponse>(url, json);
            }
            catch (Exception ex)
            {
                return new _BaseResponse() { code = -1, msg = ex.Message };
            }
        }
        #endregion

        #region 期权
        /// <summary>
        /// 期权-期权合约信息
        /// </summary>
        /// <param name="exchange"></param>
        /// <param name="call_put"></param>

        public _BaseResponse opt_basic(string exchange, string call_put)
        {
            try
            {
                Dictionary<string, string> paramsList = new Dictionary<string, string>();
                paramsList.Add("exchange", exchange);
                paramsList.Add("call_put", call_put);


                OptBasicRequest request = new OptBasicRequest
                {
                    token = Token,
                    api_name = "opt_basic",
                    paramsList = paramsList
                };
                string json = JsonConvert.SerializeObject(request,
                    new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });
                return request.Request<_BaseResponse>(url, json);
            }
            catch (Exception ex)
            {
                return new _BaseResponse() { code = -1, msg = ex.Message };
            }
        }

        /// <summary>
        /// 期权-期权日线行情
        /// </summary>
        /// <param name="trade_date"></param>
        /// <param name="ts_code"></param>
        /// <param name="exchange"></param>
        /// <param name="start_date"></param>
        /// <param name="end_date"></param>
        public _BaseResponse opt_daily( string ts_code, string trade_date, string start_date, string end_date, string exchange)
        {
            try
            {
                Dictionary<string, string> paramsList = new Dictionary<string, string>();
                paramsList.Add("ts_code", ts_code);
                paramsList.Add("trade_date", trade_date);
                paramsList.Add("start_date", start_date);
                paramsList.Add("end_date", end_date);
                paramsList.Add("exchange", exchange);

                OptDailyRequest request = new OptDailyRequest
                {
                    token = Token,
                    api_name = "opt_daily",
                    paramsList = paramsList
                };
                string json = JsonConvert.SerializeObject(request,
                    new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });
                return request.Request<_BaseResponse>(url, json);
            }
            catch (Exception ex)
            {
                return new _BaseResponse() { code = -1, msg = ex.Message };
            }
        }
        #endregion

        #region 外汇
        /// <summary>
        /// 外汇-外汇基础信息（海外）
        /// </summary>
        /// <param name="exchange"></param>
        /// <param name="classify"></param>
        /// <param name="ts_code"></param>
        public _BaseResponse fx_obasic(string exchange, string classify, string ts_code)
        {
            try
            {
                Dictionary<string, string> paramsList = new Dictionary<string, string>();
                paramsList.Add("exchange", exchange);
                paramsList.Add("classify", classify);
                paramsList.Add("ts_code", ts_code);
                

                FxObasicRequest request = new FxObasicRequest
                {
                    token = Token,
                    api_name = "fx_obasic",
                    paramsList = paramsList
                };
                string json = JsonConvert.SerializeObject(request,
                    new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });
                return request.Request<_BaseResponse>(url, json);
            }
            catch (Exception ex)
            {
                return new _BaseResponse() { code = -1, msg = ex.Message };
            }
        }

        /// <summary>
        /// 外汇-外汇日线行情
        /// </summary>
        /// <param name="ts_code"></param>
        /// <param name="trade_date"></param>
        /// <param name="start_date"></param>
        /// <param name="end_date"></param>
        /// <param name="exchange"></param>
        public _BaseResponse fx_daily(string ts_code, string trade_date, string start_date, string end_date, string exchange)
        {
            try
            {
                Dictionary<string, string> paramsList = new Dictionary<string, string>();
                paramsList.Add("ts_code", ts_code);
                paramsList.Add("trade_date", trade_date);
                paramsList.Add("start_date", start_date);
                paramsList.Add("end_date", end_date);
                paramsList.Add("exchange", exchange);


                FxDailyRequest request = new FxDailyRequest
                {
                    token = Token,
                    api_name = "fx_daily",
                    paramsList = paramsList
                };
                string json = JsonConvert.SerializeObject(request,
                    new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });
                return request.Request<_BaseResponse>(url, json);
            }
            catch (Exception ex)
            {
                return new _BaseResponse() { code = -1, msg = ex.Message };
            }
        }
        #endregion

        #region 宏观经济
        /// <summary>
        /// 宏观经济-SHIBOR利率数据
        /// </summary>
        /// <param name="date"></param>
        /// <param name="start_date"></param>
        /// <param name="end_date"></param>
        public _BaseResponse shibor(string date, string start_date, string end_date)
        {
            try
            {
                Dictionary<string, string> paramsList = new Dictionary<string, string>();
                paramsList.Add("date", date);
                paramsList.Add("start_date", start_date);
                paramsList.Add("end_date", end_date);

                ShiborRequest request = new ShiborRequest
                {
                    token = Token,
                    api_name = "shibor",
                    paramsList = paramsList
                };
                string json = JsonConvert.SerializeObject(request,
                    new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });
                return request.Request<_BaseResponse>(url, json);
            }
            catch (Exception ex)
            {
                return new _BaseResponse() { code = -1, msg = ex.Message };
            }
        }

        /// <summary>
        /// 宏观经济-SHIBOR报价数据
        /// </summary>
        /// <param name="date"></param>
        /// <param name="start_date"></param>
        /// <param name="end_date"></param>
        /// <param name="bank"></param>
        public _BaseResponse shibor_quote(string date, string start_date, string end_date,string bank)
        {
            try
            {
                Dictionary<string, string> paramsList = new Dictionary<string, string>();
                paramsList.Add("date", date);
                paramsList.Add("start_date", start_date);
                paramsList.Add("end_date", end_date);
                paramsList.Add("bank", bank);

                ShiborQuoteRequest request = new ShiborQuoteRequest
                {
                    token = Token,
                    api_name = "shibor_quote",
                    paramsList = paramsList
                };
                string json = JsonConvert.SerializeObject(request,
                    new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });
                return request.Request<_BaseResponse>(url, json);
            }
            catch (Exception ex)
            {
                return new _BaseResponse() { code = -1, msg = ex.Message };
            }
        }

        /// <summary>
        /// 宏观经济-LPR贷款基础利率
        /// </summary>
        /// <param name="date"></param>
        /// <param name="start_date"></param>
        /// <param name="end_date"></param>
        public _BaseResponse shibor_lpr(string date, string start_date, string end_date)
        {
            try
            {
                Dictionary<string, string> paramsList = new Dictionary<string, string>();
                paramsList.Add("date", date);
                paramsList.Add("start_date", start_date);
                paramsList.Add("end_date", end_date);

                ShiborLprRequest request = new ShiborLprRequest
                {
                    token = Token,
                    api_name = "shibor_lpr",
                    paramsList = paramsList
                };
                string json = JsonConvert.SerializeObject(request,
                    new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });
                return request.Request<_BaseResponse>(url, json);
            }
            catch (Exception ex)
            {
                return new _BaseResponse() { code = -1, msg = ex.Message };
            }
        }

        /// <summary>
        /// 宏观经济-LIBOR拆借利率
        /// </summary>
        /// <param name="date"></param>
        /// <param name="start_date"></param>
        /// <param name="end_date"></param>
        /// <param name="curr_type"></param>
        public _BaseResponse libor(string date, string start_date, string end_date, string curr_type)
        {
            try
            {
                Dictionary<string, string> paramsList = new Dictionary<string, string>();
                paramsList.Add("date", date);
                paramsList.Add("start_date", start_date);
                paramsList.Add("end_date", end_date);
                paramsList.Add("curr_type", curr_type);

                LiborRequest request = new LiborRequest
                {
                    token = Token,
                    api_name = "libor",
                    paramsList = paramsList
                };
                string json = JsonConvert.SerializeObject(request,
                    new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });
                return request.Request<_BaseResponse>(url, json);
            }
            catch (Exception ex)
            {
                return new _BaseResponse() { code = -1, msg = ex.Message };
            }
        }

        /// <summary>
        /// 宏观经济-HIBOR利率
        /// </summary>
        /// <param name="date"></param>
        /// <param name="start_date"></param>
        /// <param name="end_date"></param>
        public _BaseResponse hibor(string date, string start_date, string end_date)
        {
            try
            {
                Dictionary<string, string> paramsList = new Dictionary<string, string>();
                paramsList.Add("date", date);
                paramsList.Add("start_date", start_date);
                paramsList.Add("end_date", end_date);

                HiborRequest request = new HiborRequest
                {
                    token = Token,
                    api_name = "hibor",
                    paramsList = paramsList
                };
                string json = JsonConvert.SerializeObject(request,
                    new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });
                return request.Request<_BaseResponse>(url, json);
            }
            catch (Exception ex)
            {
                return new _BaseResponse() { code = -1, msg = ex.Message };
            }
        }

        /// <summary>
        /// 宏观经济-温州民间借贷利率
        /// </summary>
        /// <param name="date"></param>
        /// <param name="start_date"></param>
        /// <param name="end_date"></param>
        public _BaseResponse wz_index(string date, string start_date, string end_date)
        {
            try
            {
                Dictionary<string, string> paramsList = new Dictionary<string, string>();
                paramsList.Add("date", date);
                paramsList.Add("start_date", start_date);
                paramsList.Add("end_date", end_date);

                WzIndexRequest request = new WzIndexRequest
                {
                    token = Token,
                    api_name = "wz_index",
                    paramsList = paramsList
                };
                string json = JsonConvert.SerializeObject(request,
                    new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });
                return request.Request<_BaseResponse>(url, json);
            }
            catch (Exception ex)
            {
                return new _BaseResponse() { code = -1, msg = ex.Message };
            }
        }

        /// <summary>
        /// 宏观经济-广州民间借贷利率
        /// </summary>
        /// <param name="date"></param>
        /// <param name="start_date"></param>
        /// <param name="end_date"></param>
        public _BaseResponse gz_index(string date, string start_date, string end_date)
        {
            try
            {
                Dictionary<string, string> paramsList = new Dictionary<string, string>();
                paramsList.Add("date", date);
                paramsList.Add("start_date", start_date);
                paramsList.Add("end_date", end_date);

                GzIndexRequest request = new GzIndexRequest
                {
                    token = Token,
                    api_name = "gz_index",
                    paramsList = paramsList
                };
                string json = JsonConvert.SerializeObject(request,
                    new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });
                return request.Request<_BaseResponse>(url, json);
            }
            catch (Exception ex)
            {
                return new _BaseResponse() { code = -1, msg = ex.Message };
            }
        }
        #endregion

        #region 特色大数据

        /// <summary>
        /// 特色大数据-新闻资讯
        /// </summary>
        /// <param name="end_date"></param>
        /// <param name="start_date"></param>
        /// <param name="src"></param>
        public _BaseResponse news(string start_date, string end_date, string src)
        {
            try
            {
                Dictionary<string, string> paramsList = new Dictionary<string, string>();
                paramsList.Add("start_date", start_date);
                paramsList.Add("end_date", end_date);
                paramsList.Add("src", src);

                NewsRequest request = new NewsRequest
                {
                    token = Token,
                    api_name = "news",
                    paramsList = paramsList
                };
                string json = JsonConvert.SerializeObject(request,
                    new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });
                return request.Request<_BaseResponse>(url, json);
            }
            catch (Exception ex)
            {
                return new _BaseResponse() { code = -1, msg = ex.Message };
            }
        }

        /// <summary>
        /// 特色大数据-新闻联播
        /// </summary>
        /// <param name="date"></param>
        public _BaseResponse cctv_news(string date)
        {
            try
            {
                Dictionary<string, string> paramsList = new Dictionary<string, string>();
                paramsList.Add("date", date);

                CctvNewsRequest request = new CctvNewsRequest
                {
                    token = Token,
                    api_name = "cctv_news",
                    paramsList = paramsList
                };
                string json = JsonConvert.SerializeObject(request,
                    new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });
                return request.Request<_BaseResponse>(url, json);
            }
            catch (Exception ex)
            {
                return new _BaseResponse() { code = -1, msg = ex.Message };
            }
        }

        /// <summary>
        /// 特色大数据-上市公司公告(信息地雷)
        /// </summary>
        /// <param name="ts_code"></param>
        /// <param name="ann_date"></param>
        /// <param name="start_date"></param>
        /// <param name="end_date"></param>
        /// <param name="year"></param>
        public _BaseResponse anns(string ts_code, string ann_date, string start_date, string end_date, string year)
        {
            try
            {
                Dictionary<string, string> paramsList = new Dictionary<string, string>();
                paramsList.Add("ts_code", ts_code);
                paramsList.Add("ann_date", ann_date);
                paramsList.Add("start_date", start_date);
                paramsList.Add("end_date", end_date);
                paramsList.Add("year", year);

                AnnsRequest request = new AnnsRequest
                {
                    token = Token,
                    api_name = "anns",
                    paramsList = paramsList
                };
                string json = JsonConvert.SerializeObject(request,
                    new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });
                return request.Request<_BaseResponse>(url, json);
            }
            catch (Exception ex)
            {
                return new _BaseResponse() { code = -1, msg = ex.Message };
            }
        }
        #endregion
    }
}
