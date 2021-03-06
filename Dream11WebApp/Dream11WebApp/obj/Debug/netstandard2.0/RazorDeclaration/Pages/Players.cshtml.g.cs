#pragma checksum "F:\CurrentWorkBk\GitRbackup\Dream11WebApp\Dream11WebApp\Pages\Players.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc9f8e685f1f457f10f9b0913cf38b20ce80fcac"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Dream11WebApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
    using System.Net.Http;
    using Microsoft.AspNetCore.Components.Forms;
    using Microsoft.AspNetCore.Components.Layouts;
    using Microsoft.AspNetCore.Components.Routing;
    using Microsoft.JSInterop;
    using Dream11WebApp;
    using Dream11WebApp.Shared;
    using Microsoft.AspNetCore.Components.Services;
    using Dream11WebApp.Model;
    [Microsoft.AspNetCore.Components.Layouts.LayoutAttribute(typeof(MainLayout))]

    [Microsoft.AspNetCore.Components.RouteAttribute("/Players/{matchid:int}/{userteamid:int}")]
    public class Players : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
        }
        #pragma warning restore 1998
#line 219 "F:\CurrentWorkBk\GitRbackup\Dream11WebApp\Dream11WebApp\Pages\Players.cshtml"
           
    [Parameter]
    int matchid { get; set; }
    [Parameter]
    int userteamid { get; set; }

    bool btncontinue { get; set; } = false;
    double totalCredits { get; set; } = 100;
    Player2[] Playerlist { get; set; }
    Player2[] playerlistlocal { get; set; }
    List<Player2> selectedPlayer { get; set; }
    ExampleJsInterop exampleJsInterop;
    Object autoken { get; set; }
    protected override async Task OnInitAsync()
    {

        appState._players.Clear();
        selectedPlayer = new List<Player2>();
        if (playerlistlocal == null)
            await LoadplayerInfo(matchid);
    }
    async Task LoadplayerInfo(int matchid)
    {
        exampleJsInterop = new ExampleJsInterop(JSRuntime);
        playerlistlocal = await exampleJsInterop.GetItem<Player2[]>("CreateTeam");
        // playerlistlocal = common.GetPlayerArray(await exampleJsInterop.GetItem<UserTeam>("CreateTeam"));
        autoken = await exampleJsInterop.GetStringItem<Object>("utoken");
        if (playerlistlocal == null)       playerlistlocal = await PlayerData.GetPlayerInfo(matchid,userteamid, autoken);
        // { playerlistlocal = await PlayerData.GetPlayerInfo(matchid, autoken); }
        //else
        //{

        if (playerlistlocal.Where(T => T.player.isSelected == true).Count() == 11) this.btncontinue = true;
        if (playerlistlocal.Where(T => T.player.isSelected == true).Count() != 11) this.btncontinue = false;
        //  }

        Playerlist = playerlistlocal.Where(p => p.player.playerRoleName == Common.PlayerType.WK.ToString()).ToArray();
        selectedPlayer = playerlistlocal.Where(T => T.player.isSelected == true).ToList();
        PlayerRoleWiseCount(playerlistlocal);
    }


    int wkCount { get; set; }
    int bastCount { get; set; }
    int alCount { get; set; }
    int bowlCount { get; set; }
    private void PlayerRoleWiseCount(Player2[] playerslistlocal)
    {
        wkCount = playerlistlocal.Where(p => (p.player.playerRoleName == Common.PlayerType.WK.ToString() && p.player.isSelected == true)).Count();
        bastCount = playerlistlocal.Where(p => (p.player.playerRoleName == Common.PlayerType.Bat.ToString() && p.player.isSelected == true)).Count();
        alCount = playerslistlocal.Where(p => (p.player.playerRoleName == Common.PlayerType.Allrounder.ToString() && p.player.isSelected == true)).Count();
        bowlCount = playerslistlocal.Where(p => (p.player.playerRoleName == Common.PlayerType.Bowler.ToString() && p.player.isSelected == true)).Count();
    }

    private string RType { get; set; } = Common.RoleType.WK.ToString();
    // private enum RoleType { WK, BAT, AR, BOWL }
    private string picklable { get; set; } = "Pick 1 Wicket-Keeper";

    private string SelectRoleTab(string roletype)
    {
        selectedPlayer = playerlistlocal.Where(p => p.player.isSelected == true).ToList();
        switch (roletype)
        {
            case "WK":
                picklable = "Pick 1 Wicket-Keeper";
                Playerlist = playerlistlocal.Where(p => p.player.playerRoleName == Common.PlayerType.WK.ToString()).ToArray();
                return RType = roletype;
            case "BAT":
                picklable = "Pick 3-5 Batsmen";
                Playerlist = playerlistlocal.Where(p => p.player.playerRoleName == Common.PlayerType.Bat.ToString()).ToArray();
                //RemoveLocalKey();
                RemoveLocalKey();
                return RType = roletype;
            case "AR":
                picklable = "Pick 1-3 All-Rounders";
                Playerlist = playerlistlocal.Where(p => p.player.playerRoleName == Common.PlayerType.Allrounder.ToString()).ToArray();
                return RType = roletype;
            case "BOWL":
                picklable = "Pick 3-5 Bowlers";
                Playerlist = playerlistlocal.Where(p => p.player.playerRoleName == Common.PlayerType.Bowler.ToString()).ToArray();
                return RType = roletype;
        }

        return RType;
    }

    protected async Task RemoveLocalKey()
    {
        await exampleJsInterop.RemoveItem("CreateTeam");
        await exampleJsInterop.RemoveItem("SaveTeam");
    }

    private void SelectPlayer(Player2 player, bool isselectplayer)
    {
        //if (selectedPlayer.Count == 5) { this.btncontinue = true; }
        //else { this.btncontinue = false; }

        int count = selectedPlayer.Where(p => p.player.playerRoleName == player.player.playerRoleName).Count();


        switch (player.player.playerRoleName)
        {
            case "WK":
                if (count <= 0) AddRemovePlayerlist(player, isselectplayer);
                if (count > 0) RemovePlayer(player, isselectplayer);

                wkCount = selectedPlayer.Where(p => p.player.playerRoleName == player.player.playerRoleName).Count();
                break;
            case "Bat":
                if (count <= 4) AddRemovePlayerlist(player, isselectplayer);
                if (count > 4) RemovePlayer(player, isselectplayer);
                bastCount = selectedPlayer.Where(p => p.player.playerRoleName == player.player.playerRoleName).Count();
                break;
            case "Allrounder":
                if (count <= 2) AddRemovePlayerlist(player, isselectplayer);
                if (count > 2) RemovePlayer(player, isselectplayer);

                alCount = selectedPlayer.Where(p => p.player.playerRoleName == player.player.playerRoleName).Count();
                break;
            case "Bowler":
                if (count <= 4) AddRemovePlayerlist(player, isselectplayer);
                if (count > 4) RemovePlayer(player, isselectplayer);

                bowlCount = selectedPlayer.Where(p => p.player.playerRoleName == player.player.playerRoleName).Count();
                break;
        }

        if (selectedPlayer.Count == 11) this.btncontinue = true;
        if (selectedPlayer.Count != 11) this.btncontinue = false;

        StateHasChanged();

        ChangePlayerStatus();
    }

    private async Task ChangePlayerStatus()
    {
        await exampleJsInterop.SetItem<Player2[]>("CreateTeam", playerlistlocal);
    }


    private void RemovePlayer(Player2 player, bool isselectplayer)
    {
        for (int i = 0; i < Playerlist.Length; i++)
        {
            if (player.player.playerId == Playerlist[i].player.playerId && isselectplayer == true)
            {
                Playerlist[i].player.isSelected = false;
                selectedPlayer.Remove(selectedPlayer.Where(p => p.player.playerId == Playerlist[i].player.playerId).First());
                //appState.RemovePlayer(player.playerId);
                totalCredits += Playerlist[i].player.credits;
                break;
            }
        }

        if (isselectplayer == false)
        {
            switch (player.player.playerRoleName)
            {
                case "WK":
                    toastService.ShowToast("you can only select upto 1 WicketKeeper", Common.ToastLevel.Warning);
                    break;
                case "Bat":
                    toastService.ShowToast("you can only select upto 5 Batsmans", Common.ToastLevel.Warning);
                    break;
                case "Allrounder":
                    toastService.ShowToast("you can only select upto 3 All-rounders", Common.ToastLevel.Warning);
                    break;
                case "Bowler":
                    toastService.ShowToast("you can only select upto 5 Bowlers", Common.ToastLevel.Warning);
                    break;
            }

        }
    }

    private void AddRemovePlayerlist(Player2 player, bool isselectplayer)
    {
        for (int i = 0; i < Playerlist.Length; i++)
        {
            if (player.player.playerId == Playerlist[i].player.playerId && isselectplayer == false)
            {
                selectedPlayer.Add(player);
                // appState.AddPlayers(player);
                Playerlist[i].player.isSelected = true;
                totalCredits -= Playerlist[i].player.credits;
                break;
            }
            if (player.player.playerId == Playerlist[i].player.playerId && isselectplayer == true)
            {
                Playerlist[i].player.isSelected = false;
                selectedPlayer.Remove(selectedPlayer.Where(p => p.player.playerId == Playerlist[i].player.playerId).First());
                //appState.RemovePlayer(player.playerId);
                totalCredits += Playerlist[i].player.credits;
                break;
            }
        }
    }

    private void UserCustomTeam()
    {
        UriHelper.NavigateTo("/SaveTeam/" + matchid+"/"+userteamid);
    }

    private void BackArrow()
    {
            UriHelper.NavigateTo("/Contest/" + matchid);
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Common common { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ToastService toastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AppState appState { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IplayerData PlayerData { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUriHelper UriHelper { get; set; }
    }
}
#pragma warning restore 1591
