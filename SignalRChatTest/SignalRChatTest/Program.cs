using SignalRChatTest.Hubs;

var builder = WebApplication.CreateBuilder(args);

// 添加密钥服务，其是指使用密钥注册和检索依赖项注入 (DI) 服务的机制
// 调用 AddKeyedSingleton （或 AddKeyedScoped 或 AddKeyedTransient）来注册服务，与密钥相关联
builder.Services.AddKeyedSingleton<ICache, BigCache>("big");
builder.Services.AddKeyedSingleton<ICache, SmallCache>("small");

// Add services to the container.
builder.Services.AddRazorPages();
// 注册 SignalR 中心所需的服务
builder.Services.AddSignalR();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

// 配置 SignalR 终结点，对应 chat.js 文件中的启动链接路径
// app.MapHub<ChatHub>("/Chat");
// 更换为强类型中心
app.MapHub<StronglyTypedChatHub>("/Chat");

app.Run();
