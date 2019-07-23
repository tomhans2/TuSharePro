### TuSharePro.Net项目说明

#### 基本信息
TuSharePro提供了便捷高效的中国金融市场数据查询服务，更多信息请关注：
- https://tushare.pro
- https://github.com/waditu/tushare

TuSharePro.Net是为了方便.Net开发者使用的Api接口封装包
- 版本要求
    > .Net 4.5
- 功能概览
    > TuSharePro数据接口：目前包括全部REST数据接口（除行业数据）   
    > ToDataTable：将数据转换成DataTable格式   
    > Utility.PrintDataTable：tab分割排版打印DataTable
- 最新版本
    > 1.0.1

#### 如何使用
##### 安装
```
Install-Package TuSharePro.Net -Version 1.0.1
```

##### 示例
    // 接口初始化
    CoreApi api= new CoreApi("your token paste here");
    // 请求数据（请求参数类型为string,非必选参数可为null/""），转DataTable，并输出结果
    Utility.PrintDataTable(api.stock_basic("",null,"").ToDataTable());
    Console.ReadKey();
![image](https://github.com/tomhans2/TuSharePro/blob/master/screenshot.PNG)
