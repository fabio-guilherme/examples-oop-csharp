Inventory playerInventory = new Inventory();

TreasureChest chest = new TreasureChest();
QuestReward questReward = new QuestReward();

chest.Open(playerInventory);
questReward.Claim(playerInventory);

playerInventory.ShowItems();
