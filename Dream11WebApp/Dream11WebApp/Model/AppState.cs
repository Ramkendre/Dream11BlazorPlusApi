using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dream11WebApp.Model
{
    public class AppState
    {
        public readonly List<Expense> _expenses = new List<Expense>();
        public IReadOnlyList<Expense> Expenses => _expenses;
        public event Action OnExpenseAdded;
        public void AddExpense(Expense expense)
        {
            _expenses.Add(expense);
            StateChanged();
        }
        private void StateChanged() => OnExpenseAdded?.Invoke();


        public readonly List<UserContest> _usercontest = new List<UserContest>();
        public IReadOnlyList<UserContest> UserContest => _usercontest;
        public event Action OnContestAdded;
        public void AddContest(UserContest ucontest)
        {
            _usercontest.Add(ucontest);
            StateChanged();
        }
        private void StateContestChanged() => OnContestAdded?.Invoke();



        public readonly List<Player> _players = new List<Player>();
        public IReadOnlyList<Player> players => _players;
        public event Action OnPlayerDisplay;
        public void AddPlayers(Player player)
        {
            _players.Add(player);
            StatePlayerChanged();
        }
        public void RemovePlayer(int id)
        {
            _players.Remove(_players.Where(p => p.playerId == id).First());
            // _players.RemoveAt(id);
            StatePlayerChanged();
        }
        private void StatePlayerChanged() => OnPlayerDisplay?.Invoke();

    }

    public class Expense
    {
        public string Description { get; set; }
        public int Amount { get; set; }
    }

}
