Inventory playerInventory = new Inventory();

TreasureChest chest = new TreasureChest();
QuestReward questReward = new QuestReward();
Shop shop = new Shop();

chest.Open(playerInventory);
questReward.Claim(playerInventory);
shop.BuyItem(playerInventory);

playerInventory.ShowItems();
