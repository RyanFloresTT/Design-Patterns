using System;

public class GameManager{
    public static GameManager instance = null;
    public bool isGameStarted = false;
    public static GameManager Instance {get {
        if (instance == null) {
            instance = new GameManager();
        } return instance;
    }}

    public void StartGame() {
        if (isGameStarted) return;
        Console.WriteLine("Game Started.");
        isGameStarted = true;
    }
}

public class Starter {
    static GameManager gameManager = GameManager.Instance;
    static GameManager otherGameManage = GameManager.Instance;
    public static void Main() {
        gameManager.StartGame();
        otherGameManage.StartGame();
    }
}