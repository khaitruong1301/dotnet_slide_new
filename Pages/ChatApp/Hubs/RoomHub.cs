namespace blazor_soan_slide.Store.Hub;

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using blazor_soan_slide.Models;
using blazor_soan_slide.ModelsOther;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.DependencyInjection;

public class RoomHub : Hub
{
    // private readonly List
    private readonly ProductStoreService _productStoreService;
    private List<Room> Rooms = new List<Room>();

    public RoomHub(IServiceProvider serviceProvider )
    {
        for(int i = 1; i <= 5; i++){
            
        }
        
        //Sử dụng http client
        // _httpStore = serviceProvider.GetRequiredService<IHttpClientFactory>().CreateClient("apiStore");
        //Sử dụng service xây dựng sẵn
    }
    public override async Task OnConnectedAsync()
    {
        Console.WriteLine($"Client connected: {Context.ConnectionId}");
        await base.OnConnectedAsync();
    }

    public override async Task OnDisconnectedAsync(Exception? exception)
    {
        // var errorMessage = exception != null ? exception.Message : "No error information.";
        // Console.WriteLine($"Client disconnected: {Context.ConnectionId}, Error: {errorMessage}");
    }
    public async Task AddProduct(ProductStore product)
    {
        // _productStoreService.CreateProduct(product);

    }
    public async Task GetAllProduct(string message)
    {
        // await Clients.All.SendAsync("GetAllProduct", _productStoreService.GetAllProductAsync());

    }
}
