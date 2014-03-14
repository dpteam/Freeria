using Microsoft.Xna.Framework;
using System;
namespace Freeria
{
	public class Item
	{
		public static int potionDelay = 3600;
		public bool wet;
		public byte wetCount;
		public bool lavaWet;
		public Vector2 position;
		public Vector2 velocity;
		public int width;
		public int height;
		public bool active;
		public int noGrabDelay;
		public bool beingGrabbed;
		public int spawnTime;
		public bool wornArmor;
		public int ownIgnore = -1;
		public int ownTime;
		public int keepTime;
		public int type;
		public string name;
		public int holdStyle;
		public int useStyle;
		public bool channel;
		public bool accessory;
		public int useAnimation;
		public int useTime;
		public int stack;
		public int maxStack;
		public int pick;
		public int axe;
		public int hammer;
		public int tileBoost;
		public int createTile = -1;
		public int createWall = -1;
		public int placeStyle;
		public int damage;
		public float knockBack;
		public int healLife;
		public int healMana;
		public bool potion;
		public bool consumable;
		public bool autoReuse;
		public bool useTurn;
		public Color color;
		public int alpha;
		public float scale = 1f;
		public int useSound;
		public int defense;
		public int headSlot = -1;
		public int bodySlot = -1;
		public int legSlot = -1;
		public string toolTip;
		public string toolTip2;
		public int owner = 255;
		public int rare;
		public int shoot;
		public float shootSpeed;
		public int ammo;
		public int useAmmo;
		public int lifeRegen;
		public int manaIncrease;
		public bool buyOnce;
		public int mana;
		public bool noUseGraphic;
		public bool noMelee;
		public int release;
		public int value;
		public bool buy;
		public bool social;
		public bool vanity;
		public bool material;
		public bool noWet;
		public int buffType;
		public int buffTime;
		public bool melee;
		public bool magic;
		public bool ranged;
		public void SetDefaults(string ItemName)
		{
			this.name = "";
			if (ItemName == "Gold Pickaxe")
			{
				this.SetDefaults(1, false);
				this.color = new Color(210, 190, 0, 100);
				this.useTime = 17;
				this.pick = 55;
				this.useAnimation = 20;
				this.scale = 1.05f;
				this.damage = 6;
				this.value = 10000;
				this.toolTip = "Can mine Meteorite";
			}
			else
			{
				if (ItemName == "Gold Broadsword")
				{
					this.SetDefaults(4, false);
					this.color = new Color(210, 190, 0, 100);
					this.useAnimation = 20;
					this.damage = 13;
					this.scale = 1.05f;
					this.value = 9000;
				}
				else
				{
					if (ItemName == "Gold Shortsword")
					{
						this.SetDefaults(6, false);
						this.color = new Color(210, 190, 0, 100);
						this.damage = 11;
						this.useAnimation = 11;
						this.scale = 0.95f;
						this.value = 7000;
					}
					else
					{
						if (ItemName == "Gold Axe")
						{
							this.SetDefaults(10, false);
							this.color = new Color(210, 190, 0, 100);
							this.useTime = 18;
							this.axe = 11;
							this.useAnimation = 26;
							this.scale = 1.15f;
							this.damage = 7;
							this.value = 8000;
						}
						else
						{
							if (ItemName == "Gold Hammer")
							{
								this.SetDefaults(7, false);
								this.color = new Color(210, 190, 0, 100);
								this.useAnimation = 28;
								this.useTime = 23;
								this.scale = 1.25f;
								this.damage = 9;
								this.hammer = 55;
								this.value = 8000;
							}
							else
							{
								if (ItemName == "Gold Bow")
								{
									this.SetDefaults(99, false);
									this.useAnimation = 26;
									this.useTime = 26;
									this.color = new Color(210, 190, 0, 100);
									this.damage = 11;
									this.value = 7000;
								}
								else
								{
									if (ItemName == "Silver Pickaxe")
									{
										this.SetDefaults(1, false);
										this.color = new Color(180, 180, 180, 100);
										this.useTime = 11;
										this.pick = 45;
										this.useAnimation = 19;
										this.scale = 1.05f;
										this.damage = 6;
										this.value = 5000;
									}
									else
									{
										if (ItemName == "Silver Broadsword")
										{
											this.SetDefaults(4, false);
											this.color = new Color(180, 180, 180, 100);
											this.useAnimation = 21;
											this.damage = 11;
											this.value = 4500;
										}
										else
										{
											if (ItemName == "Silver Shortsword")
											{
												this.SetDefaults(6, false);
												this.color = new Color(180, 180, 180, 100);
												this.damage = 9;
												this.useAnimation = 12;
												this.scale = 0.95f;
												this.value = 3500;
											}
											else
											{
												if (ItemName == "Silver Axe")
												{
													this.SetDefaults(10, false);
													this.color = new Color(180, 180, 180, 100);
													this.useTime = 18;
													this.axe = 10;
													this.useAnimation = 26;
													this.scale = 1.15f;
													this.damage = 6;
													this.value = 4000;
												}
												else
												{
													if (ItemName == "Silver Hammer")
													{
														this.SetDefaults(7, false);
														this.color = new Color(180, 180, 180, 100);
														this.useAnimation = 29;
														this.useTime = 19;
														this.scale = 1.25f;
														this.damage = 9;
														this.hammer = 45;
														this.value = 4000;
													}
													else
													{
														if (ItemName == "Silver Bow")
														{
															this.SetDefaults(99, false);
															this.useAnimation = 27;
															this.useTime = 27;
															this.color = new Color(180, 180, 180, 100);
															this.damage = 9;
															this.value = 3500;
														}
														else
														{
															if (ItemName == "Copper Pickaxe")
															{
																this.SetDefaults(1, false);
																this.color = new Color(180, 100, 45, 80);
																this.useTime = 15;
																this.pick = 35;
																this.useAnimation = 23;
																this.damage = 4;
																this.scale = 0.9f;
																this.tileBoost = -1;
																this.value = 500;
															}
															else
															{
																if (ItemName == "Copper Broadsword")
																{
																	this.SetDefaults(4, false);
																	this.color = new Color(180, 100, 45, 80);
																	this.useAnimation = 23;
																	this.damage = 8;
																	this.value = 450;
																}
																else
																{
																	if (ItemName == "Copper Shortsword")
																	{
																		this.SetDefaults(6, false);
																		this.color = new Color(180, 100, 45, 80);
																		this.damage = 5;
																		this.useAnimation = 13;
																		this.scale = 0.8f;
																		this.value = 350;
																	}
																	else
																	{
																		if (ItemName == "Copper Axe")
																		{
																			this.SetDefaults(10, false);
																			this.color = new Color(180, 100, 45, 80);
																			this.useTime = 21;
																			this.axe = 7;
																			this.useAnimation = 30;
																			this.scale = 1f;
																			this.damage = 3;
																			this.tileBoost = -1;
																			this.value = 400;
																		}
																		else
																		{
																			if (ItemName == "Copper Hammer")
																			{
																				this.SetDefaults(7, false);
																				this.color = new Color(180, 100, 45, 80);
																				this.useAnimation = 33;
																				this.useTime = 23;
																				this.scale = 1.1f;
																				this.damage = 4;
																				this.hammer = 35;
																				this.tileBoost = -1;
																				this.value = 400;
																			}
																			else
																			{
																				if (ItemName == "Copper Bow")
																				{
																					this.SetDefaults(99, false);
																					this.useAnimation = 29;
																					this.useTime = 29;
																					this.color = new Color(180, 100, 45, 80);
																					this.damage = 6;
																					this.value = 350;
																				}
																				else
																				{
																					if (ItemName != "")
																					{
																						for (int i = 0; i < 364; i++)
																						{
																							if (Main.itemName[i] == ItemName)
																							{
																								this.SetDefaults(i, false);
																								this.checkMat();
																								return;
																							}
																						}
																						this.name = "";
																						this.stack = 0;
																						this.type = 0;
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			if (this.type != 0)
			{
				this.checkMat();
				this.name = ItemName;
			}
		}
		public bool checkMat()
		{
			if (this.type >= 71 && this.type <= 74)
			{
				this.material = false;
				return false;
			}
			for (int i = 0; i < Recipe.numRecipes; i++)
			{
				int num = 0;
				while (Main.recipe[i].requiredItem[num].type > 0)
				{
					if (this.name == Main.recipe[i].requiredItem[num].name)
					{
						this.material = true;
						return true;
					}
					num++;
				}
			}
			this.material = false;
			return false;
		}
		public void SetDefaults(int Type, bool noMatCheck = false)
		{
			if (Main.netMode == 1 || Main.netMode == 2)
			{
				this.owner = 255;
			}
			else
			{
				this.owner = Main.myPlayer;
			}
			this.melee = false;
			this.magic = false;
			this.ranged = false;
			this.placeStyle = 0;
			this.buffTime = 0;
			this.buffType = 0;
			this.material = false;
			this.noWet = false;
			this.vanity = false;
			this.mana = 0;
			this.wet = false;
			this.wetCount = 0;
			this.lavaWet = false;
			this.channel = false;
			this.manaIncrease = 0;
			this.release = 0;
			this.noMelee = false;
			this.noUseGraphic = false;
			this.lifeRegen = 0;
			this.shootSpeed = 0f;
			this.active = true;
			this.alpha = 0;
			this.ammo = 0;
			this.useAmmo = 0;
			this.autoReuse = false;
			this.accessory = false;
			this.axe = 0;
			this.healMana = 0;
			this.bodySlot = -1;
			this.legSlot = -1;
			this.headSlot = -1;
			this.potion = false;
			this.color = default(Color);
			this.consumable = false;
			this.createTile = -1;
			this.createWall = -1;
			this.damage = -1;
			this.defense = 0;
			this.hammer = 0;
			this.healLife = 0;
			this.holdStyle = 0;
			this.knockBack = 0f;
			this.maxStack = 1;
			this.pick = 0;
			this.rare = 0;
			this.scale = 1f;
			this.shoot = 0;
			this.stack = 1;
			this.toolTip = null;
			this.toolTip2 = null;
			this.tileBoost = 0;
			this.type = Type;
			this.useStyle = 0;
			this.useSound = 0;
			this.useTime = 100;
			this.useAnimation = 100;
			this.value = 0;
			this.useTurn = false;
			this.buy = false;
			if (this.type == 0)
			{
				this.name = "";
				this.stack = 0;
			}
			else
			{
				if (this.type == 1)
				{
					this.name = "Iron Pickaxe";
					this.useStyle = 1;
					this.useTurn = true;
					this.useAnimation = 20;
					this.useTime = 13;
					this.autoReuse = true;
					this.width = 24;
					this.height = 28;
					this.damage = 5;
					this.pick = 40;
					this.useSound = 1;
					this.knockBack = 2f;
					this.value = 2000;
					this.melee = true;
				}
				else
				{
					if (this.type == 2)
					{
						this.name = "Dirt Block";
						this.useStyle = 1;
						this.useTurn = true;
						this.useAnimation = 15;
						this.useTime = 10;
						this.autoReuse = true;
						this.maxStack = 250;
						this.consumable = true;
						this.createTile = 0;
						this.width = 12;
						this.height = 12;
					}
					else
					{
						if (this.type == 3)
						{
							this.name = "Stone Block";
							this.useStyle = 1;
							this.useTurn = true;
							this.useAnimation = 15;
							this.useTime = 10;
							this.autoReuse = true;
							this.maxStack = 250;
							this.consumable = true;
							this.createTile = 1;
							this.width = 12;
							this.height = 12;
						}
						else
						{
							if (this.type == 4)
							{
								this.name = "Iron Broadsword";
								this.useStyle = 1;
								this.useTurn = false;
								this.useAnimation = 21;
								this.useTime = 21;
								this.width = 24;
								this.height = 28;
								this.damage = 10;
								this.knockBack = 5f;
								this.useSound = 1;
								this.scale = 1f;
								this.value = 1800;
								this.melee = true;
							}
							else
							{
								if (this.type == 5)
								{
									this.name = "Mushroom";
									this.useStyle = 2;
									this.useSound = 2;
									this.useTurn = false;
									this.useAnimation = 17;
									this.useTime = 17;
									this.width = 16;
									this.height = 18;
									this.healLife = 15;
									this.maxStack = 99;
									this.consumable = true;
									this.potion = true;
									this.value = 25;
								}
								else
								{
									if (this.type == 6)
									{
										this.name = "Iron Shortsword";
										this.useStyle = 3;
										this.useTurn = false;
										this.useAnimation = 12;
										this.useTime = 12;
										this.width = 24;
										this.height = 28;
										this.damage = 8;
										this.knockBack = 4f;
										this.scale = 0.9f;
										this.useSound = 1;
										this.useTurn = true;
										this.value = 1400;
										this.melee = true;
									}
									else
									{
										if (this.type == 7)
										{
											this.name = "Iron Hammer";
											this.autoReuse = true;
											this.useStyle = 1;
											this.useTurn = true;
											this.useAnimation = 30;
											this.useTime = 20;
											this.hammer = 45;
											this.width = 24;
											this.height = 28;
											this.damage = 7;
											this.knockBack = 5.5f;
											this.scale = 1.2f;
											this.useSound = 1;
											this.value = 1600;
											this.melee = true;
										}
										else
										{
											if (this.type == 8)
											{
												this.noWet = true;
												this.name = "Torch";
												this.useStyle = 1;
												this.useTurn = true;
												this.useAnimation = 15;
												this.useTime = 10;
												this.holdStyle = 1;
												this.autoReuse = true;
												this.maxStack = 99;
												this.consumable = true;
												this.createTile = 4;
												this.width = 10;
												this.height = 12;
												this.toolTip = "Provides light";
												this.value = 50;
											}
											else
											{
												if (this.type == 9)
												{
													this.name = "Wood";
													this.useStyle = 1;
													this.useTurn = true;
													this.useAnimation = 15;
													this.useTime = 10;
													this.autoReuse = true;
													this.maxStack = 250;
													this.consumable = true;
													this.createTile = 30;
													this.width = 8;
													this.height = 10;
												}
												else
												{
													if (this.type == 10)
													{
														this.name = "Iron Axe";
														this.useStyle = 1;
														this.useTurn = true;
														this.useAnimation = 27;
														this.knockBack = 4.5f;
														this.useTime = 19;
														this.autoReuse = true;
														this.width = 24;
														this.height = 28;
														this.damage = 5;
														this.axe = 9;
														this.scale = 1.1f;
														this.useSound = 1;
														this.value = 1600;
														this.melee = true;
													}
													else
													{
														if (this.type == 11)
														{
															this.name = "Iron Ore";
															this.useStyle = 1;
															this.useTurn = true;
															this.useAnimation = 15;
															this.useTime = 10;
															this.autoReuse = true;
															this.maxStack = 99;
															this.consumable = true;
															this.createTile = 6;
															this.width = 12;
															this.height = 12;
															this.value = 500;
														}
														else
														{
															if (this.type == 12)
															{
																this.name = "Copper Ore";
																this.useStyle = 1;
																this.useTurn = true;
																this.useAnimation = 15;
																this.useTime = 10;
																this.autoReuse = true;
																this.maxStack = 99;
																this.consumable = true;
																this.createTile = 7;
																this.width = 12;
																this.height = 12;
																this.value = 250;
															}
															else
															{
																if (this.type == 13)
																{
																	this.name = "Gold Ore";
																	this.useStyle = 1;
																	this.useTurn = true;
																	this.useAnimation = 15;
																	this.useTime = 10;
																	this.autoReuse = true;
																	this.maxStack = 99;
																	this.consumable = true;
																	this.createTile = 8;
																	this.width = 12;
																	this.height = 12;
																	this.value = 2000;
																}
																else
																{
																	if (this.type == 14)
																	{
																		this.name = "Silver Ore";
																		this.useStyle = 1;
																		this.useTurn = true;
																		this.useAnimation = 15;
																		this.useTime = 10;
																		this.autoReuse = true;
																		this.maxStack = 99;
																		this.consumable = true;
																		this.createTile = 9;
																		this.width = 12;
																		this.height = 12;
																		this.value = 1000;
																	}
																	else
																	{
																		if (this.type == 15)
																		{
																			this.name = "Copper Watch";
																			this.width = 24;
																			this.height = 28;
																			this.accessory = true;
																			this.toolTip = "Tells the time";
																			this.value = 1000;
																		}
																		else
																		{
																			if (this.type == 16)
																			{
																				this.name = "Silver Watch";
																				this.width = 24;
																				this.height = 28;
																				this.accessory = true;
																				this.toolTip = "Tells the time";
																				this.value = 5000;
																			}
																			else
																			{
																				if (this.type == 17)
																				{
																					this.name = "Gold Watch";
																					this.width = 24;
																					this.height = 28;
																					this.accessory = true;
																					this.rare = 1;
																					this.toolTip = "Tells the time";
																					this.value = 10000;
																				}
																				else
																				{
																					if (this.type == 18)
																					{
																						this.name = "Depth Meter";
																						this.width = 24;
																						this.height = 18;
																						this.accessory = true;
																						this.rare = 1;
																						this.toolTip = "Shows depth";
																						this.value = 10000;
																					}
																					else
																					{
																						if (this.type == 19)
																						{
																							this.name = "Gold Bar";
																							this.width = 20;
																							this.height = 20;
																							this.maxStack = 99;
																							this.value = 6000;
																						}
																						else
																						{
																							if (this.type == 20)
																							{
																								this.name = "Copper Bar";
																								this.width = 20;
																								this.height = 20;
																								this.maxStack = 99;
																								this.value = 750;
																							}
																							else
																							{
																								if (this.type == 21)
																								{
																									this.name = "Silver Bar";
																									this.width = 20;
																									this.height = 20;
																									this.maxStack = 99;
																									this.value = 3000;
																								}
																								else
																								{
																									if (this.type == 22)
																									{
																										this.name = "Iron Bar";
																										this.width = 20;
																										this.height = 20;
																										this.maxStack = 99;
																										this.value = 1500;
																									}
																									else
																									{
																										if (this.type == 23)
																										{
																											this.name = "Gel";
																											this.width = 10;
																											this.height = 12;
																											this.maxStack = 99;
																											this.alpha = 175;
																											this.color = new Color(0, 80, 255, 100);
																											this.toolTip = "'Both tasty and flammable'";
																											this.value = 5;
																										}
																										else
																										{
																											if (this.type == 24)
																											{
																												this.name = "Wooden Sword";
																												this.useStyle = 1;
																												this.useTurn = false;
																												this.useAnimation = 25;
																												this.width = 24;
																												this.height = 28;
																												this.damage = 7;
																												this.knockBack = 4f;
																												this.scale = 0.95f;
																												this.useSound = 1;
																												this.value = 100;
																												this.melee = true;
																											}
																											else
																											{
																												if (this.type == 25)
																												{
																													this.name = "Wooden Door";
																													this.useStyle = 1;
																													this.useTurn = true;
																													this.useAnimation = 15;
																													this.useTime = 10;
																													this.maxStack = 99;
																													this.consumable = true;
																													this.createTile = 10;
																													this.width = 14;
																													this.height = 28;
																													this.value = 200;
																												}
																												else
																												{
																													if (this.type == 26)
																													{
																														this.name = "Stone Wall";
																														this.useStyle = 1;
																														this.useTurn = true;
																														this.useAnimation = 15;
																														this.useTime = 7;
																														this.autoReuse = true;
																														this.maxStack = 250;
																														this.consumable = true;
																														this.createWall = 1;
																														this.width = 12;
																														this.height = 12;
																													}
																													else
																													{
																														if (this.type == 27)
																														{
																															this.name = "Acorn";
																															this.useTurn = true;
																															this.useStyle = 1;
																															this.useAnimation = 15;
																															this.useTime = 10;
																															this.maxStack = 99;
																															this.consumable = true;
																															this.createTile = 20;
																															this.width = 18;
																															this.height = 18;
																															this.value = 10;
																														}
																														else
																														{
																															if (this.type == 28)
																															{
																																this.name = "Lesser Healing Potion";
																																this.useSound = 3;
																																this.healLife = 50;
																																this.useStyle = 2;
																																this.useTurn = true;
																																this.useAnimation = 17;
																																this.useTime = 17;
																																this.maxStack = 30;
																																this.consumable = true;
																																this.width = 14;
																																this.height = 24;
																																this.potion = true;
																																this.value = 300;
																															}
																															else
																															{
																																if (this.type == 29)
																																{
																																	this.name = "Life Crystal";
																																	this.maxStack = 99;
																																	this.consumable = true;
																																	this.width = 18;
																																	this.height = 18;
																																	this.useStyle = 4;
																																	this.useTime = 30;
																																	this.useSound = 4;
																																	this.useAnimation = 30;
																																	this.toolTip = "Permanently increases maximum life by 20";
																																	this.rare = 2;
																																}
																																else
																																{
																																	if (this.type == 30)
																																	{
																																		this.name = "Dirt Wall";
																																		this.useStyle = 1;
																																		this.useTurn = true;
																																		this.useAnimation = 15;
																																		this.useTime = 7;
																																		this.autoReuse = true;
																																		this.maxStack = 250;
																																		this.consumable = true;
																																		this.createWall = 16;
																																		this.width = 12;
																																		this.height = 12;
																																	}
																																	else
																																	{
																																		if (this.type == 31)
																																		{
																																			this.name = "Bottle";
																																			this.useStyle = 1;
																																			this.useTurn = true;
																																			this.useAnimation = 15;
																																			this.useTime = 10;
																																			this.autoReuse = true;
																																			this.maxStack = 99;
																																			this.consumable = true;
																																			this.createTile = 13;
																																			this.width = 16;
																																			this.height = 24;
																																			this.value = 20;
																																		}
																																		else
																																		{
																																			if (this.type == 32)
																																			{
																																				this.name = "Wooden Table";
																																				this.useStyle = 1;
																																				this.useTurn = true;
																																				this.useAnimation = 15;
																																				this.useTime = 10;
																																				this.autoReuse = true;
																																				this.maxStack = 99;
																																				this.consumable = true;
																																				this.createTile = 14;
																																				this.width = 26;
																																				this.height = 20;
																																				this.value = 300;
																																			}
																																			else
																																			{
																																				if (this.type == 33)
																																				{
																																					this.name = "Furnace";
																																					this.useStyle = 1;
																																					this.useTurn = true;
																																					this.useAnimation = 15;
																																					this.useTime = 10;
																																					this.autoReuse = true;
																																					this.maxStack = 99;
																																					this.consumable = true;
																																					this.createTile = 17;
																																					this.width = 26;
																																					this.height = 24;
																																					this.value = 300;
																																					this.toolTip = "Used for smelting ore";
																																				}
																																				else
																																				{
																																					if (this.type == 34)
																																					{
																																						this.name = "Wooden Chair";
																																						this.useStyle = 1;
																																						this.useTurn = true;
																																						this.useAnimation = 15;
																																						this.useTime = 10;
																																						this.autoReuse = true;
																																						this.maxStack = 99;
																																						this.consumable = true;
																																						this.createTile = 15;
																																						this.width = 12;
																																						this.height = 30;
																																						this.value = 150;
																																					}
																																					else
																																					{
																																						if (this.type == 35)
																																						{
																																							this.name = "Iron Anvil";
																																							this.useStyle = 1;
																																							this.useTurn = true;
																																							this.useAnimation = 15;
																																							this.useTime = 10;
																																							this.autoReuse = true;
																																							this.maxStack = 99;
																																							this.consumable = true;
																																							this.createTile = 16;
																																							this.width = 28;
																																							this.height = 14;
																																							this.value = 5000;
																																							this.toolTip = "Used to craft items from metal bars";
																																						}
																																						else
																																						{
																																							if (this.type == 36)
																																							{
																																								this.name = "Work Bench";
																																								this.useStyle = 1;
																																								this.useTurn = true;
																																								this.useAnimation = 15;
																																								this.useTime = 10;
																																								this.autoReuse = true;
																																								this.maxStack = 99;
																																								this.consumable = true;
																																								this.createTile = 18;
																																								this.width = 28;
																																								this.height = 14;
																																								this.value = 150;
																																								this.toolTip = "Used for basic crafting";
																																							}
																																							else
																																							{
																																								if (this.type == 37)
																																								{
																																									this.name = "Goggles";
																																									this.width = 28;
																																									this.height = 12;
																																									this.defense = 1;
																																									this.headSlot = 10;
																																									this.rare = 1;
																																									this.value = 1000;
																																								}
																																								else
																																								{
																																									if (this.type == 38)
																																									{
																																										this.name = "Lens";
																																										this.width = 12;
																																										this.height = 20;
																																										this.maxStack = 99;
																																										this.value = 500;
																																									}
																																									else
																																									{
																																										if (this.type == 39)
																																										{
																																											this.useStyle = 5;
																																											this.useAnimation = 30;
																																											this.useTime = 30;
																																											this.name = "Wooden Bow";
																																											this.width = 12;
																																											this.height = 28;
																																											this.shoot = 1;
																																											this.useAmmo = 1;
																																											this.useSound = 5;
																																											this.damage = 4;
																																											this.shootSpeed = 6.1f;
																																											this.noMelee = true;
																																											this.value = 100;
																																											this.ranged = true;
																																										}
																																										else
																																										{
																																											if (this.type == 40)
																																											{
																																												this.name = "Wooden Arrow";
																																												this.shootSpeed = 3f;
																																												this.shoot = 1;
																																												this.damage = 4;
																																												this.width = 10;
																																												this.height = 28;
																																												this.maxStack = 250;
																																												this.consumable = true;
																																												this.ammo = 1;
																																												this.knockBack = 2f;
																																												this.value = 10;
																																												this.ranged = true;
																																											}
																																											else
																																											{
																																												if (this.type == 41)
																																												{
																																													this.name = "Flaming Arrow";
																																													this.shootSpeed = 3.5f;
																																													this.shoot = 2;
																																													this.damage = 6;
																																													this.width = 10;
																																													this.height = 28;
																																													this.maxStack = 250;
																																													this.consumable = true;
																																													this.ammo = 1;
																																													this.knockBack = 2f;
																																													this.value = 15;
																																													this.ranged = true;
																																												}
																																												else
																																												{
																																													if (this.type == 42)
																																													{
																																														this.useStyle = 1;
																																														this.name = "Shuriken";
																																														this.shootSpeed = 9f;
																																														this.shoot = 3;
																																														this.damage = 10;
																																														this.width = 18;
																																														this.height = 20;
																																														this.maxStack = 250;
																																														this.consumable = true;
																																														this.useSound = 1;
																																														this.useAnimation = 15;
																																														this.useTime = 15;
																																														this.noUseGraphic = true;
																																														this.noMelee = true;
																																														this.value = 20;
																																														this.ranged = true;
																																													}
																																													else
																																													{
																																														if (this.type == 43)
																																														{
																																															this.useStyle = 4;
																																															this.name = "Suspicious Looking Eye";
																																															this.width = 22;
																																															this.height = 14;
																																															this.consumable = true;
																																															this.useAnimation = 45;
																																															this.useTime = 45;
																																															this.toolTip = "Summons the Eye of Cthulhu";
																																														}
																																														else
																																														{
																																															if (this.type == 44)
																																															{
																																																this.useStyle = 5;
																																																this.useAnimation = 25;
																																																this.useTime = 25;
																																																this.name = "Demon Bow";
																																																this.width = 12;
																																																this.height = 28;
																																																this.shoot = 1;
																																																this.useAmmo = 1;
																																																this.useSound = 5;
																																																this.damage = 14;
																																																this.shootSpeed = 6.7f;
																																																this.knockBack = 1f;
																																																this.alpha = 30;
																																																this.rare = 1;
																																																this.noMelee = true;
																																																this.value = 18000;
																																																this.ranged = true;
																																															}
																																															else
																																															{
																																																if (this.type == 45)
																																																{
																																																	this.name = "War Axe of the Night";
																																																	this.autoReuse = true;
																																																	this.useStyle = 1;
																																																	this.useAnimation = 30;
																																																	this.knockBack = 6f;
																																																	this.useTime = 15;
																																																	this.width = 24;
																																																	this.height = 28;
																																																	this.damage = 20;
																																																	this.axe = 15;
																																																	this.scale = 1.2f;
																																																	this.useSound = 1;
																																																	this.rare = 1;
																																																	this.value = 13500;
																																																	this.melee = true;
																																																}
																																																else
																																																{
																																																	if (this.type == 46)
																																																	{
																																																		this.name = "Light's Bane";
																																																		this.useStyle = 1;
																																																		this.useAnimation = 20;
																																																		this.knockBack = 5f;
																																																		this.width = 24;
																																																		this.height = 28;
																																																		this.damage = 17;
																																																		this.scale = 1.1f;
																																																		this.useSound = 1;
																																																		this.rare = 1;
																																																		this.value = 13500;
																																																		this.melee = true;
																																																	}
																																																	else
																																																	{
																																																		if (this.type == 47)
																																																		{
																																																			this.name = "Unholy Arrow";
																																																			this.shootSpeed = 3.4f;
																																																			this.shoot = 4;
																																																			this.damage = 8;
																																																			this.width = 10;
																																																			this.height = 28;
																																																			this.maxStack = 250;
																																																			this.consumable = true;
																																																			this.ammo = 1;
																																																			this.knockBack = 3f;
																																																			this.alpha = 30;
																																																			this.rare = 1;
																																																			this.value = 40;
																																																			this.ranged = true;
																																																		}
																																																		else
																																																		{
																																																			if (this.type == 48)
																																																			{
																																																				this.name = "Chest";
																																																				this.useStyle = 1;
																																																				this.useTurn = true;
																																																				this.useAnimation = 15;
																																																				this.useTime = 10;
																																																				this.autoReuse = true;
																																																				this.maxStack = 99;
																																																				this.consumable = true;
																																																				this.createTile = 21;
																																																				this.width = 26;
																																																				this.height = 22;
																																																				this.value = 500;
																																																			}
																																																			else
																																																			{
																																																				if (this.type == 49)
																																																				{
																																																					this.name = "Band of Regeneration";
																																																					this.width = 22;
																																																					this.height = 22;
																																																					this.accessory = true;
																																																					this.lifeRegen = 1;
																																																					this.rare = 1;
																																																					this.toolTip = "Slowly regenerates life";
																																																					this.value = 50000;
																																																				}
																																																				else
																																																				{
																																																					if (this.type == 50)
																																																					{
																																																						this.mana = 20;
																																																						this.name = "Magic Mirror";
																																																						this.useTurn = true;
																																																						this.width = 20;
																																																						this.height = 20;
																																																						this.useStyle = 4;
																																																						this.useTime = 90;
																																																						this.useSound = 6;
																																																						this.useAnimation = 90;
																																																						this.toolTip = "Gaze in the mirror to return home";
																																																						this.rare = 1;
																																																						this.value = 50000;
																																																					}
																																																					else
																																																					{
																																																						if (this.type == 51)
																																																						{
																																																							this.name = "Jester's Arrow";
																																																							this.shootSpeed = 0.5f;
																																																							this.shoot = 5;
																																																							this.damage = 9;
																																																							this.width = 10;
																																																							this.height = 28;
																																																							this.maxStack = 250;
																																																							this.consumable = true;
																																																							this.ammo = 1;
																																																							this.knockBack = 4f;
																																																							this.rare = 1;
																																																							this.value = 100;
																																																							this.ranged = true;
																																																						}
																																																						else
																																																						{
																																																							if (this.type == 52)
																																																							{
																																																								this.name = "Angel Statue";
																																																								this.width = 24;
																																																								this.height = 28;
																																																								this.toolTip = "'It doesn't do anything'";
																																																								this.value = 1;
																																																							}
																																																							else
																																																							{
																																																								if (this.type == 53)
																																																								{
																																																									this.name = "Cloud in a Bottle";
																																																									this.width = 16;
																																																									this.height = 24;
																																																									this.accessory = true;
																																																									this.rare = 1;
																																																									this.toolTip = "Allows the holder to double jump";
																																																									this.value = 50000;
																																																								}
																																																								else
																																																								{
																																																									if (this.type == 54)
																																																									{
																																																										this.name = "Hermes Boots";
																																																										this.width = 28;
																																																										this.height = 24;
																																																										this.accessory = true;
																																																										this.rare = 1;
																																																										this.toolTip = "The wearer can run super fast";
																																																										this.value = 50000;
																																																									}
																																																									else
																																																									{
																																																										if (this.type == 55)
																																																										{
																																																											this.noMelee = true;
																																																											this.useStyle = 1;
																																																											this.name = "Enchanted Boomerang";
																																																											this.shootSpeed = 10f;
																																																											this.shoot = 6;
																																																											this.damage = 13;
																																																											this.knockBack = 8f;
																																																											this.width = 14;
																																																											this.height = 28;
																																																											this.useSound = 1;
																																																											this.useAnimation = 15;
																																																											this.useTime = 15;
																																																											this.noUseGraphic = true;
																																																											this.rare = 1;
																																																											this.value = 50000;
																																																											this.ranged = true;
																																																										}
																																																										else
																																																										{
																																																											if (this.type == 56)
																																																											{
																																																												this.name = "Demonite Ore";
																																																												this.useStyle = 1;
																																																												this.useTurn = true;
																																																												this.useAnimation = 15;
																																																												this.useTime = 10;
																																																												this.autoReuse = true;
																																																												this.maxStack = 99;
																																																												this.consumable = true;
																																																												this.createTile = 22;
																																																												this.width = 12;
																																																												this.height = 12;
																																																												this.rare = 1;
																																																												this.toolTip = "'Pulsing with dark energy'";
																																																												this.value = 4000;
																																																											}
																																																											else
																																																											{
																																																												if (this.type == 57)
																																																												{
																																																													this.name = "Demonite Bar";
																																																													this.width = 20;
																																																													this.height = 20;
																																																													this.maxStack = 99;
																																																													this.rare = 1;
																																																													this.toolTip = "'Pulsing with dark energy'";
																																																													this.value = 16000;
																																																												}
																																																												else
																																																												{
																																																													if (this.type == 58)
																																																													{
																																																														this.name = "Heart";
																																																														this.width = 12;
																																																														this.height = 12;
																																																													}
																																																													else
																																																													{
																																																														if (this.type == 59)
																																																														{
																																																															this.name = "Corrupt Seeds";
																																																															this.useTurn = true;
																																																															this.useStyle = 1;
																																																															this.useAnimation = 15;
																																																															this.useTime = 10;
																																																															this.maxStack = 99;
																																																															this.consumable = true;
																																																															this.createTile = 23;
																																																															this.width = 14;
																																																															this.height = 14;
																																																															this.value = 500;
																																																														}
																																																														else
																																																														{
																																																															if (this.type == 60)
																																																															{
																																																																this.name = "Vile Mushroom";
																																																																this.width = 16;
																																																																this.height = 18;
																																																																this.maxStack = 99;
																																																																this.value = 50;
																																																															}
																																																															else
																																																															{
																																																																if (this.type == 61)
																																																																{
																																																																	this.name = "Ebonstone Block";
																																																																	this.useStyle = 1;
																																																																	this.useTurn = true;
																																																																	this.useAnimation = 15;
																																																																	this.useTime = 10;
																																																																	this.autoReuse = true;
																																																																	this.maxStack = 250;
																																																																	this.consumable = true;
																																																																	this.createTile = 25;
																																																																	this.width = 12;
																																																																	this.height = 12;
																																																																}
																																																																else
																																																																{
																																																																	if (this.type == 62)
																																																																	{
																																																																		this.name = "Grass Seeds";
																																																																		this.useTurn = true;
																																																																		this.useStyle = 1;
																																																																		this.useAnimation = 15;
																																																																		this.useTime = 10;
																																																																		this.maxStack = 99;
																																																																		this.consumable = true;
																																																																		this.createTile = 2;
																																																																		this.width = 14;
																																																																		this.height = 14;
																																																																		this.value = 20;
																																																																	}
																																																																	else
																																																																	{
																																																																		if (this.type == 63)
																																																																		{
																																																																			this.name = "Sunflower";
																																																																			this.useTurn = true;
																																																																			this.useStyle = 1;
																																																																			this.useAnimation = 15;
																																																																			this.useTime = 10;
																																																																			this.maxStack = 99;
																																																																			this.consumable = true;
																																																																			this.createTile = 27;
																																																																			this.width = 26;
																																																																			this.height = 26;
																																																																			this.value = 200;
																																																																		}
																																																																		else
																																																																		{
																																																																			if (this.type == 64)
																																																																			{
																																																																				this.mana = 12;
																																																																				this.damage = 8;
																																																																				this.useStyle = 1;
																																																																				this.name = "Vilethorn";
																																																																				this.shootSpeed = 32f;
																																																																				this.shoot = 7;
																																																																				this.width = 26;
																																																																				this.height = 28;
																																																																				this.useSound = 8;
																																																																				this.useAnimation = 30;
																																																																				this.useTime = 30;
																																																																				this.rare = 1;
																																																																				this.noMelee = true;
																																																																				this.knockBack = 1f;
																																																																				this.toolTip = "Summons a vile thorn";
																																																																				this.value = 10000;
																																																																				this.magic = true;
																																																																			}
																																																																			else
																																																																			{
																																																																				if (this.type == 65)
																																																																				{
																																																																					this.autoReuse = true;
																																																																					this.mana = 16;
																																																																					this.knockBack = 5f;
																																																																					this.alpha = 100;
																																																																					this.color = new Color(150, 150, 150, 0);
																																																																					this.damage = 16;
																																																																					this.useStyle = 1;
																																																																					this.scale = 1.15f;
																																																																					this.name = "Starfury";
																																																																					this.shootSpeed = 12f;
																																																																					this.shoot = 9;
																																																																					this.width = 14;
																																																																					this.height = 28;
																																																																					this.useSound = 9;
																																																																					this.useAnimation = 25;
																																																																					this.useTime = 10;
																																																																					this.rare = 1;
																																																																					this.toolTip = "Causes stars to rain from the sky";
																																																																					this.toolTip2 = "'Forged with the fury of heaven'";
																																																																					this.value = 50000;
																																																																					this.magic = true;
																																																																				}
																																																																				else
																																																																				{
																																																																					if (this.type == 66)
																																																																					{
																																																																						this.useStyle = 1;
																																																																						this.name = "Purification Powder";
																																																																						this.shootSpeed = 4f;
																																																																						this.shoot = 10;
																																																																						this.width = 16;
																																																																						this.height = 24;
																																																																						this.maxStack = 99;
																																																																						this.consumable = true;
																																																																						this.useSound = 1;
																																																																						this.useAnimation = 15;
																																																																						this.useTime = 15;
																																																																						this.noMelee = true;
																																																																						this.toolTip = "Cleanses the corruption";
																																																																						this.value = 75;
																																																																					}
																																																																					else
																																																																					{
																																																																						if (this.type == 67)
																																																																						{
																																																																							this.damage = 8;
																																																																							this.useStyle = 1;
																																																																							this.name = "Vile Powder";
																																																																							this.shootSpeed = 4f;
																																																																							this.shoot = 11;
																																																																							this.width = 16;
																																																																							this.height = 24;
																																																																							this.maxStack = 99;
																																																																							this.consumable = true;
																																																																							this.useSound = 1;
																																																																							this.useAnimation = 15;
																																																																							this.useTime = 15;
																																																																							this.noMelee = true;
																																																																							this.value = 100;
																																																																						}
																																																																						else
																																																																						{
																																																																							if (this.type == 68)
																																																																							{
																																																																								this.name = "Rotten Chunk";
																																																																								this.width = 18;
																																																																								this.height = 20;
																																																																								this.maxStack = 99;
																																																																								this.toolTip = "'Looks tasty!'";
																																																																								this.value = 10;
																																																																							}
																																																																							else
																																																																							{
																																																																								if (this.type == 69)
																																																																								{
																																																																									this.name = "Worm Tooth";
																																																																									this.width = 8;
																																																																									this.height = 20;
																																																																									this.maxStack = 99;
																																																																									this.value = 100;
																																																																								}
																																																																								else
																																																																								{
																																																																									if (this.type == 70)
																																																																									{
																																																																										this.useStyle = 4;
																																																																										this.consumable = true;
																																																																										this.useAnimation = 45;
																																																																										this.useTime = 45;
																																																																										this.name = "Worm Food";
																																																																										this.width = 28;
																																																																										this.height = 28;
																																																																										this.toolTip = "Summons the Eater of Worlds";
																																																																									}
																																																																									else
																																																																									{
																																																																										if (this.type == 71)
																																																																										{
																																																																											this.name = "Copper Coin";
																																																																											this.width = 10;
																																																																											this.height = 12;
																																																																											this.maxStack = 100;
																																																																											this.value = 5;
																																																																										}
																																																																										else
																																																																										{
																																																																											if (this.type == 72)
																																																																											{
																																																																												this.name = "Silver Coin";
																																																																												this.width = 10;
																																																																												this.height = 12;
																																																																												this.maxStack = 100;
																																																																												this.value = 500;
																																																																											}
																																																																											else
																																																																											{
																																																																												if (this.type == 73)
																																																																												{
																																																																													this.name = "Gold Coin";
																																																																													this.width = 10;
																																																																													this.height = 12;
																																																																													this.maxStack = 100;
																																																																													this.value = 50000;
																																																																												}
																																																																												else
																																																																												{
																																																																													if (this.type == 74)
																																																																													{
																																																																														this.name = "Platinum Coin";
																																																																														this.width = 10;
																																																																														this.height = 12;
																																																																														this.maxStack = 100;
																																																																														this.value = 5000000;
																																																																													}
																																																																													else
																																																																													{
																																																																														if (this.type == 75)
																																																																														{
																																																																															this.name = "Fallen Star";
																																																																															this.width = 18;
																																																																															this.height = 20;
																																																																															this.maxStack = 100;
																																																																															this.alpha = 75;
																																																																															this.ammo = 15;
																																																																															this.toolTip = "Disappears after the sunrise";
																																																																															this.value = 500;
																																																																															this.useStyle = 4;
																																																																															this.useSound = 4;
																																																																															this.useTurn = false;
																																																																															this.useAnimation = 17;
																																																																															this.useTime = 17;
																																																																															this.healMana = 20;
																																																																															this.consumable = true;
																																																																															this.rare = 1;
																																																																															this.potion = true;
																																																																														}
																																																																														else
																																																																														{
																																																																															if (this.type == 76)
																																																																															{
																																																																																this.name = "Copper Greaves";
																																																																																this.width = 18;
																																																																																this.height = 18;
																																																																																this.defense = 1;
																																																																																this.legSlot = 1;
																																																																																this.value = 750;
																																																																															}
																																																																															else
																																																																															{
																																																																																if (this.type == 77)
																																																																																{
																																																																																	this.name = "Iron Greaves";
																																																																																	this.width = 18;
																																																																																	this.height = 18;
																																																																																	this.defense = 2;
																																																																																	this.legSlot = 2;
																																																																																	this.value = 3000;
																																																																																}
																																																																																else
																																																																																{
																																																																																	if (this.type == 78)
																																																																																	{
																																																																																		this.name = "Silver Greaves";
																																																																																		this.width = 18;
																																																																																		this.height = 18;
																																																																																		this.defense = 3;
																																																																																		this.legSlot = 3;
																																																																																		this.value = 7500;
																																																																																	}
																																																																																	else
																																																																																	{
																																																																																		if (this.type == 79)
																																																																																		{
																																																																																			this.name = "Gold Greaves";
																																																																																			this.width = 18;
																																																																																			this.height = 18;
																																																																																			this.defense = 4;
																																																																																			this.legSlot = 4;
																																																																																			this.value = 15000;
																																																																																		}
																																																																																		else
																																																																																		{
																																																																																			if (this.type == 80)
																																																																																			{
																																																																																				this.name = "Copper Chainmail";
																																																																																				this.width = 18;
																																																																																				this.height = 18;
																																																																																				this.defense = 2;
																																																																																				this.bodySlot = 1;
																																																																																				this.value = 1000;
																																																																																			}
																																																																																			else
																																																																																			{
																																																																																				if (this.type == 81)
																																																																																				{
																																																																																					this.name = "Iron Chainmail";
																																																																																					this.width = 18;
																																																																																					this.height = 18;
																																																																																					this.defense = 3;
																																																																																					this.bodySlot = 2;
																																																																																					this.value = 4000;
																																																																																				}
																																																																																				else
																																																																																				{
																																																																																					if (this.type == 82)
																																																																																					{
																																																																																						this.name = "Silver Chainmail";
																																																																																						this.width = 18;
																																																																																						this.height = 18;
																																																																																						this.defense = 4;
																																																																																						this.bodySlot = 3;
																																																																																						this.value = 10000;
																																																																																					}
																																																																																					else
																																																																																					{
																																																																																						if (this.type == 83)
																																																																																						{
																																																																																							this.name = "Gold Chainmail";
																																																																																							this.width = 18;
																																																																																							this.height = 18;
																																																																																							this.defense = 5;
																																																																																							this.bodySlot = 4;
																																																																																							this.value = 20000;
																																																																																						}
																																																																																						else
																																																																																						{
																																																																																							if (this.type == 84)
																																																																																							{
																																																																																								this.noUseGraphic = true;
																																																																																								this.damage = 0;
																																																																																								this.knockBack = 7f;
																																																																																								this.useStyle = 5;
																																																																																								this.name = "Grappling Hook";
																																																																																								this.shootSpeed = 11f;
																																																																																								this.shoot = 13;
																																																																																								this.width = 18;
																																																																																								this.height = 28;
																																																																																								this.useSound = 1;
																																																																																								this.useAnimation = 20;
																																																																																								this.useTime = 20;
																																																																																								this.rare = 1;
																																																																																								this.noMelee = true;
																																																																																								this.value = 20000;
																																																																																								this.toolTip = "'Get over here!'";
																																																																																							}
																																																																																							else
																																																																																							{
																																																																																								if (this.type == 85)
																																																																																								{
																																																																																									this.name = "Iron Chain";
																																																																																									this.width = 14;
																																																																																									this.height = 20;
																																																																																									this.maxStack = 99;
																																																																																									this.value = 1000;
																																																																																								}
																																																																																								else
																																																																																								{
																																																																																									if (this.type == 86)
																																																																																									{
																																																																																										this.name = "Shadow Scale";
																																																																																										this.width = 14;
																																																																																										this.height = 18;
																																																																																										this.maxStack = 99;
																																																																																										this.rare = 1;
																																																																																										this.value = 500;
																																																																																									}
																																																																																									else
																																																																																									{
																																																																																										if (this.type == 87)
																																																																																										{
																																																																																											this.name = "Piggy Bank";
																																																																																											this.useStyle = 1;
																																																																																											this.useTurn = true;
																																																																																											this.useAnimation = 15;
																																																																																											this.useTime = 10;
																																																																																											this.autoReuse = true;
																																																																																											this.maxStack = 99;
																																																																																											this.consumable = true;
																																																																																											this.createTile = 29;
																																																																																											this.width = 20;
																																																																																											this.height = 12;
																																																																																											this.value = 10000;
																																																																																										}
																																																																																										else
																																																																																										{
																																																																																											if (this.type == 88)
																																																																																											{
																																																																																												this.name = "Mining Helmet";
																																																																																												this.width = 22;
																																																																																												this.height = 16;
																																																																																												this.defense = 1;
																																																																																												this.headSlot = 11;
																																																																																												this.rare = 1;
																																																																																												this.value = 80000;
																																																																																												this.toolTip = "Provides light when worn";
																																																																																											}
																																																																																											else
																																																																																											{
																																																																																												if (this.type == 89)
																																																																																												{
																																																																																													this.name = "Copper Helmet";
																																																																																													this.width = 18;
																																																																																													this.height = 18;
																																																																																													this.defense = 1;
																																																																																													this.headSlot = 1;
																																																																																													this.value = 1250;
																																																																																												}
																																																																																												else
																																																																																												{
																																																																																													if (this.type == 90)
																																																																																													{
																																																																																														this.name = "Iron Helmet";
																																																																																														this.width = 18;
																																																																																														this.height = 18;
																																																																																														this.defense = 2;
																																																																																														this.headSlot = 2;
																																																																																														this.value = 5000;
																																																																																													}
																																																																																													else
																																																																																													{
																																																																																														if (this.type == 91)
																																																																																														{
																																																																																															this.name = "Silver Helmet";
																																																																																															this.width = 18;
																																																																																															this.height = 18;
																																																																																															this.defense = 3;
																																																																																															this.headSlot = 3;
																																																																																															this.value = 12500;
																																																																																														}
																																																																																														else
																																																																																														{
																																																																																															if (this.type == 92)
																																																																																															{
																																																																																																this.name = "Gold Helmet";
																																																																																																this.width = 18;
																																																																																																this.height = 18;
																																																																																																this.defense = 4;
																																																																																																this.headSlot = 4;
																																																																																																this.value = 25000;
																																																																																															}
																																																																																															else
																																																																																															{
																																																																																																if (this.type == 93)
																																																																																																{
																																																																																																	this.name = "Wood Wall";
																																																																																																	this.useStyle = 1;
																																																																																																	this.useTurn = true;
																																																																																																	this.useAnimation = 15;
																																																																																																	this.useTime = 7;
																																																																																																	this.autoReuse = true;
																																																																																																	this.maxStack = 250;
																																																																																																	this.consumable = true;
																																																																																																	this.createWall = 4;
																																																																																																	this.width = 12;
																																																																																																	this.height = 12;
																																																																																																}
																																																																																																else
																																																																																																{
																																																																																																	if (this.type == 94)
																																																																																																	{
																																																																																																		this.name = "Wood Platform";
																																																																																																		this.useStyle = 1;
																																																																																																		this.useTurn = true;
																																																																																																		this.useAnimation = 15;
																																																																																																		this.useTime = 10;
																																																																																																		this.autoReuse = true;
																																																																																																		this.maxStack = 99;
																																																																																																		this.consumable = true;
																																																																																																		this.createTile = 19;
																																																																																																		this.width = 8;
																																																																																																		this.height = 10;
																																																																																																	}
																																																																																																	else
																																																																																																	{
																																																																																																		if (this.type == 95)
																																																																																																		{
																																																																																																			this.useStyle = 5;
																																																																																																			this.useAnimation = 16;
																																																																																																			this.useTime = 16;
																																																																																																			this.name = "Flintlock Pistol";
																																																																																																			this.width = 24;
																																																																																																			this.height = 28;
																																																																																																			this.shoot = 14;
																																																																																																			this.useAmmo = 14;
																																																																																																			this.useSound = 11;
																																																																																																			this.damage = 10;
																																																																																																			this.shootSpeed = 5f;
																																																																																																			this.noMelee = true;
																																																																																																			this.value = 50000;
																																																																																																			this.scale = 0.9f;
																																																																																																			this.rare = 1;
																																																																																																			this.ranged = true;
																																																																																																		}
																																																																																																		else
																																																																																																		{
																																																																																																			if (this.type == 96)
																																																																																																			{
																																																																																																				this.useStyle = 5;
																																																																																																				this.autoReuse = true;
																																																																																																				this.useAnimation = 43;
																																																																																																				this.useTime = 43;
																																																																																																				this.name = "Musket";
																																																																																																				this.width = 44;
																																																																																																				this.height = 14;
																																																																																																				this.shoot = 10;
																																																																																																				this.useAmmo = 14;
																																																																																																				this.useSound = 11;
																																																																																																				this.damage = 23;
																																																																																																				this.shootSpeed = 8f;
																																																																																																				this.noMelee = true;
																																																																																																				this.value = 100000;
																																																																																																				this.knockBack = 4f;
																																																																																																				this.rare = 1;
																																																																																																				this.ranged = true;
																																																																																																			}
																																																																																																			else
																																																																																																			{
																																																																																																				if (this.type == 97)
																																																																																																				{
																																																																																																					this.name = "Musket Ball";
																																																																																																					this.shootSpeed = 4f;
																																																																																																					this.shoot = 14;
																																																																																																					this.damage = 7;
																																																																																																					this.width = 8;
																																																																																																					this.height = 8;
																																																																																																					this.maxStack = 250;
																																																																																																					this.consumable = true;
																																																																																																					this.ammo = 14;
																																																																																																					this.knockBack = 2f;
																																																																																																					this.value = 7;
																																																																																																					this.ranged = true;
																																																																																																				}
																																																																																																				else
																																																																																																				{
																																																																																																					if (this.type == 98)
																																																																																																					{
																																																																																																						this.useStyle = 5;
																																																																																																						this.autoReuse = true;
																																																																																																						this.useAnimation = 8;
																																																																																																						this.useTime = 8;
																																																																																																						this.name = "Minishark";
																																																																																																						this.width = 50;
																																																																																																						this.height = 18;
																																																																																																						this.shoot = 10;
																																																																																																						this.useAmmo = 14;
																																																																																																						this.useSound = 11;
																																																																																																						this.damage = 6;
																																																																																																						this.shootSpeed = 7f;
																																																																																																						this.noMelee = true;
																																																																																																						this.value = 400000;
																																																																																																						this.rare = 2;
																																																																																																						this.toolTip = "33% chance to not consume ammo";
																																																																																																						this.toolTip2 = "'Half shark, half gun, completely awesome.'";
																																																																																																						this.ranged = true;
																																																																																																					}
																																																																																																					else
																																																																																																					{
																																																																																																						if (this.type == 99)
																																																																																																						{
																																																																																																							this.useStyle = 5;
																																																																																																							this.useAnimation = 28;
																																																																																																							this.useTime = 28;
																																																																																																							this.name = "Iron Bow";
																																																																																																							this.width = 12;
																																																																																																							this.height = 28;
																																																																																																							this.shoot = 1;
																																																																																																							this.useAmmo = 1;
																																																																																																							this.useSound = 5;
																																																																																																							this.damage = 8;
																																																																																																							this.shootSpeed = 6.6f;
																																																																																																							this.noMelee = true;
																																																																																																							this.value = 1400;
																																																																																																							this.ranged = true;
																																																																																																						}
																																																																																																						else
																																																																																																						{
																																																																																																							if (this.type == 100)
																																																																																																							{
																																																																																																								this.name = "Shadow Greaves";
																																																																																																								this.width = 18;
																																																																																																								this.height = 18;
																																																																																																								this.defense = 6;
																																																																																																								this.legSlot = 5;
																																																																																																								this.rare = 1;
																																																																																																								this.value = 22500;
																																																																																																								this.toolTip = "7% increased melee speed";
																																																																																																							}
																																																																																																							else
																																																																																																							{
																																																																																																								if (this.type == 101)
																																																																																																								{
																																																																																																									this.name = "Shadow Scalemail";
																																																																																																									this.width = 18;
																																																																																																									this.height = 18;
																																																																																																									this.defense = 7;
																																																																																																									this.bodySlot = 5;
																																																																																																									this.rare = 1;
																																																																																																									this.value = 30000;
																																																																																																									this.toolTip = "7% increased melee speed";
																																																																																																								}
																																																																																																								else
																																																																																																								{
																																																																																																									if (this.type == 102)
																																																																																																									{
																																																																																																										this.name = "Shadow Helmet";
																																																																																																										this.width = 18;
																																																																																																										this.height = 18;
																																																																																																										this.defense = 6;
																																																																																																										this.headSlot = 5;
																																																																																																										this.rare = 1;
																																																																																																										this.value = 37500;
																																																																																																										this.toolTip = "7% increased melee speed";
																																																																																																									}
																																																																																																									else
																																																																																																									{
																																																																																																										if (this.type == 103)
																																																																																																										{
																																																																																																											this.name = "Nightmare Pickaxe";
																																																																																																											this.useStyle = 1;
																																																																																																											this.useTurn = true;
																																																																																																											this.useAnimation = 20;
																																																																																																											this.useTime = 15;
																																																																																																											this.autoReuse = true;
																																																																																																											this.width = 24;
																																																																																																											this.height = 28;
																																																																																																											this.damage = 9;
																																																																																																											this.pick = 65;
																																																																																																											this.useSound = 1;
																																																																																																											this.knockBack = 3f;
																																																																																																											this.rare = 1;
																																																																																																											this.value = 18000;
																																																																																																											this.scale = 1.15f;
																																																																																																											this.toolTip = "Able to mine Hellstone";
																																																																																																											this.melee = true;
																																																																																																										}
																																																																																																										else
																																																																																																										{
																																																																																																											if (this.type == 104)
																																																																																																											{
																																																																																																												this.name = "The Breaker";
																																																																																																												this.autoReuse = true;
																																																																																																												this.useStyle = 1;
																																																																																																												this.useAnimation = 45;
																																																																																																												this.useTime = 19;
																																																																																																												this.hammer = 55;
																																																																																																												this.width = 24;
																																																																																																												this.height = 28;
																																																																																																												this.damage = 24;
																																																																																																												this.knockBack = 6f;
																																																																																																												this.scale = 1.3f;
																																																																																																												this.useSound = 1;
																																																																																																												this.rare = 1;
																																																																																																												this.value = 15000;
																																																																																																												this.melee = true;
																																																																																																											}
																																																																																																											else
																																																																																																											{
																																																																																																												if (this.type == 105)
																																																																																																												{
																																																																																																													this.noWet = true;
																																																																																																													this.name = "Candle";
																																																																																																													this.useStyle = 1;
																																																																																																													this.useTurn = true;
																																																																																																													this.useAnimation = 15;
																																																																																																													this.useTime = 10;
																																																																																																													this.autoReuse = true;
																																																																																																													this.maxStack = 99;
																																																																																																													this.consumable = true;
																																																																																																													this.createTile = 33;
																																																																																																													this.width = 8;
																																																																																																													this.height = 18;
																																																																																																													this.holdStyle = 1;
																																																																																																												}
																																																																																																												else
																																																																																																												{
																																																																																																													if (this.type == 106)
																																																																																																													{
																																																																																																														this.name = "Copper Chandelier";
																																																																																																														this.useStyle = 1;
																																																																																																														this.useTurn = true;
																																																																																																														this.useAnimation = 15;
																																																																																																														this.useTime = 10;
																																																																																																														this.autoReuse = true;
																																																																																																														this.maxStack = 99;
																																																																																																														this.consumable = true;
																																																																																																														this.createTile = 34;
																																																																																																														this.width = 26;
																																																																																																														this.height = 26;
																																																																																																													}
																																																																																																													else
																																																																																																													{
																																																																																																														if (this.type == 107)
																																																																																																														{
																																																																																																															this.name = "Silver Chandelier";
																																																																																																															this.useStyle = 1;
																																																																																																															this.useTurn = true;
																																																																																																															this.useAnimation = 15;
																																																																																																															this.useTime = 10;
																																																																																																															this.autoReuse = true;
																																																																																																															this.maxStack = 99;
																																																																																																															this.consumable = true;
																																																																																																															this.createTile = 35;
																																																																																																															this.width = 26;
																																																																																																															this.height = 26;
																																																																																																														}
																																																																																																														else
																																																																																																														{
																																																																																																															if (this.type == 108)
																																																																																																															{
																																																																																																																this.name = "Gold Chandelier";
																																																																																																																this.useStyle = 1;
																																																																																																																this.useTurn = true;
																																																																																																																this.useAnimation = 15;
																																																																																																																this.useTime = 10;
																																																																																																																this.autoReuse = true;
																																																																																																																this.maxStack = 99;
																																																																																																																this.consumable = true;
																																																																																																																this.createTile = 36;
																																																																																																																this.width = 26;
																																																																																																																this.height = 26;
																																																																																																															}
																																																																																																															else
																																																																																																															{
																																																																																																																if (this.type == 109)
																																																																																																																{
																																																																																																																	this.name = "Mana Crystal";
																																																																																																																	this.maxStack = 99;
																																																																																																																	this.consumable = true;
																																																																																																																	this.width = 18;
																																																																																																																	this.height = 18;
																																																																																																																	this.useStyle = 4;
																																																																																																																	this.useTime = 30;
																																																																																																																	this.useSound = 4;
																																																																																																																	this.useAnimation = 30;
																																																																																																																	this.toolTip = "Permanently increases maximum mana by 20";
																																																																																																																	this.rare = 2;
																																																																																																																}
																																																																																																																else
																																																																																																																{
																																																																																																																	if (this.type == 110)
																																																																																																																	{
																																																																																																																		this.name = "Lesser Mana Potion";
																																																																																																																		this.useSound = 3;
																																																																																																																		this.healMana = 50;
																																																																																																																		this.useStyle = 2;
																																																																																																																		this.useTurn = true;
																																																																																																																		this.useAnimation = 17;
																																																																																																																		this.useTime = 17;
																																																																																																																		this.maxStack = 30;
																																																																																																																		this.consumable = true;
																																																																																																																		this.width = 14;
																																																																																																																		this.height = 24;
																																																																																																																		this.value = 1000;
																																																																																																																	}
																																																																																																																	else
																																																																																																																	{
																																																																																																																		if (this.type == 111)
																																																																																																																		{
																																																																																																																			this.name = "Band of Starpower";
																																																																																																																			this.width = 22;
																																																																																																																			this.height = 22;
																																																																																																																			this.accessory = true;
																																																																																																																			this.rare = 1;
																																																																																																																			this.toolTip = "Increases maximum mana by 20";
																																																																																																																			this.value = 50000;
																																																																																																																		}
																																																																																																																		else
																																																																																																																		{
																																																																																																																			if (this.type == 112)
																																																																																																																			{
																																																																																																																				this.mana = 19;
																																																																																																																				this.damage = 44;
																																																																																																																				this.useStyle = 1;
																																																																																																																				this.name = "Flower of Fire";
																																																																																																																				this.shootSpeed = 6f;
																																																																																																																				this.shoot = 15;
																																																																																																																				this.width = 26;
																																																																																																																				this.height = 28;
																																																																																																																				this.useSound = 20;
																																																																																																																				this.useAnimation = 20;
																																																																																																																				this.useTime = 20;
																																																																																																																				this.rare = 3;
																																																																																																																				this.noMelee = true;
																																																																																																																				this.knockBack = 5.5f;
																																																																																																																				this.toolTip = "Throws balls of fire";
																																																																																																																				this.value = 10000;
																																																																																																																				this.magic = true;
																																																																																																																			}
																																																																																																																			else
																																																																																																																			{
																																																																																																																				if (this.type == 113)
																																																																																																																				{
																																																																																																																					this.mana = 10;
																																																																																																																					this.channel = true;
																																																																																																																					this.damage = 22;
																																																																																																																					this.useStyle = 1;
																																																																																																																					this.name = "Magic Missile";
																																																																																																																					this.shootSpeed = 6f;
																																																																																																																					this.shoot = 16;
																																																																																																																					this.width = 26;
																																																																																																																					this.height = 28;
																																																																																																																					this.useSound = 9;
																																																																																																																					this.useAnimation = 17;
																																																																																																																					this.useTime = 17;
																																																																																																																					this.rare = 2;
																																																																																																																					this.noMelee = true;
																																																																																																																					this.knockBack = 5f;
																																																																																																																					this.toolTip = "Casts a controllable missile";
																																																																																																																					this.value = 10000;
																																																																																																																					this.magic = true;
																																																																																																																				}
																																																																																																																				else
																																																																																																																				{
																																																																																																																					if (this.type == 114)
																																																																																																																					{
																																																																																																																						this.mana = 5;
																																																																																																																						this.channel = true;
																																																																																																																						this.damage = 0;
																																																																																																																						this.useStyle = 1;
																																																																																																																						this.name = "Dirt Rod";
																																																																																																																						this.shoot = 17;
																																																																																																																						this.width = 26;
																																																																																																																						this.height = 28;
																																																																																																																						this.useSound = 8;
																																																																																																																						this.useAnimation = 20;
																																																																																																																						this.useTime = 20;
																																																																																																																						this.rare = 1;
																																																																																																																						this.noMelee = true;
																																																																																																																						this.knockBack = 5f;
																																																																																																																						this.toolTip = "Magically move dirt";
																																																																																																																						this.value = 200000;
																																																																																																																					}
																																																																																																																					else
																																																																																																																					{
																																																																																																																						if (this.type == 115)
																																																																																																																						{
																																																																																																																							this.mana = 40;
																																																																																																																							this.channel = true;
																																																																																																																							this.damage = 0;
																																																																																																																							this.useStyle = 4;
																																																																																																																							this.name = "Orb of Light";
																																																																																																																							this.shoot = 18;
																																																																																																																							this.width = 24;
																																																																																																																							this.height = 24;
																																																																																																																							this.useSound = 8;
																																																																																																																							this.useAnimation = 20;
																																																																																																																							this.useTime = 20;
																																																																																																																							this.rare = 1;
																																																																																																																							this.noMelee = true;
																																																																																																																							this.toolTip = "Creates a magical orb of light";
																																																																																																																							this.value = 10000;
																																																																																																																							this.buffType = 19;
																																																																																																																							this.buffTime = 18000;
																																																																																																																						}
																																																																																																																						else
																																																																																																																						{
																																																																																																																							if (this.type == 116)
																																																																																																																							{
																																																																																																																								this.name = "Meteorite";
																																																																																																																								this.useStyle = 1;
																																																																																																																								this.useTurn = true;
																																																																																																																								this.useAnimation = 15;
																																																																																																																								this.useTime = 10;
																																																																																																																								this.autoReuse = true;
																																																																																																																								this.maxStack = 250;
																																																																																																																								this.consumable = true;
																																																																																																																								this.createTile = 37;
																																																																																																																								this.width = 12;
																																																																																																																								this.height = 12;
																																																																																																																								this.value = 1000;
																																																																																																																							}
																																																																																																																							else
																																																																																																																							{
																																																																																																																								if (this.type == 117)
																																																																																																																								{
																																																																																																																									this.name = "Meteorite Bar";
																																																																																																																									this.width = 20;
																																																																																																																									this.height = 20;
																																																																																																																									this.maxStack = 99;
																																																																																																																									this.rare = 1;
																																																																																																																									this.toolTip = "'Warm to the touch'";
																																																																																																																									this.value = 7000;
																																																																																																																								}
																																																																																																																								else
																																																																																																																								{
																																																																																																																									if (this.type == 118)
																																																																																																																									{
																																																																																																																										this.name = "Hook";
																																																																																																																										this.maxStack = 99;
																																																																																																																										this.width = 18;
																																																																																																																										this.height = 18;
																																																																																																																										this.value = 1000;
																																																																																																																									}
																																																																																																																									else
																																																																																																																									{
																																																																																																																										if (this.type == 119)
																																																																																																																										{
																																																																																																																											this.noMelee = true;
																																																																																																																											this.useStyle = 1;
																																																																																																																											this.name = "Flamarang";
																																																																																																																											this.shootSpeed = 11f;
																																																																																																																											this.shoot = 19;
																																																																																																																											this.damage = 32;
																																																																																																																											this.knockBack = 8f;
																																																																																																																											this.width = 14;
																																																																																																																											this.height = 28;
																																																																																																																											this.useSound = 1;
																																																																																																																											this.useAnimation = 15;
																																																																																																																											this.useTime = 15;
																																																																																																																											this.noUseGraphic = true;
																																																																																																																											this.rare = 3;
																																																																																																																											this.value = 100000;
																																																																																																																											this.ranged = true;
																																																																																																																										}
																																																																																																																										else
																																																																																																																										{
																																																																																																																											if (this.type == 120)
																																																																																																																											{
																																																																																																																												this.useStyle = 5;
																																																																																																																												this.useAnimation = 25;
																																																																																																																												this.useTime = 25;
																																																																																																																												this.name = "Molten Fury";
																																																																																																																												this.width = 14;
																																																																																																																												this.height = 32;
																																																																																																																												this.shoot = 1;
																																																																																																																												this.useAmmo = 1;
																																																																																																																												this.useSound = 5;
																																																																																																																												this.damage = 29;
																																																																																																																												this.shootSpeed = 8f;
																																																																																																																												this.knockBack = 2f;
																																																																																																																												this.alpha = 30;
																																																																																																																												this.rare = 3;
																																																																																																																												this.noMelee = true;
																																																																																																																												this.scale = 1.1f;
																																																																																																																												this.value = 27000;
																																																																																																																												this.toolTip = "Lights wooden arrows ablaze";
																																																																																																																												this.ranged = true;
																																																																																																																											}
																																																																																																																											else
																																																																																																																											{
																																																																																																																												if (this.type == 121)
																																																																																																																												{
																																																																																																																													this.name = "Fiery Greatsword";
																																																																																																																													this.useStyle = 1;
																																																																																																																													this.useAnimation = 34;
																																																																																																																													this.knockBack = 6.5f;
																																																																																																																													this.width = 24;
																																																																																																																													this.height = 28;
																																																																																																																													this.damage = 36;
																																																																																																																													this.scale = 1.3f;
																																																																																																																													this.useSound = 1;
																																																																																																																													this.rare = 3;
																																																																																																																													this.value = 27000;
																																																																																																																													this.toolTip = "'It's made out of fire!'";
																																																																																																																													this.melee = true;
																																																																																																																												}
																																																																																																																											}
																																																																																																																										}
																																																																																																																									}
																																																																																																																								}
																																																																																																																							}
																																																																																																																						}
																																																																																																																					}
																																																																																																																				}
																																																																																																																			}
																																																																																																																		}
																																																																																																																	}
																																																																																																																}
																																																																																																															}
																																																																																																														}
																																																																																																													}
																																																																																																												}
																																																																																																											}
																																																																																																										}
																																																																																																									}
																																																																																																								}
																																																																																																							}
																																																																																																						}
																																																																																																					}
																																																																																																				}
																																																																																																			}
																																																																																																		}
																																																																																																	}
																																																																																																}
																																																																																															}
																																																																																														}
																																																																																													}
																																																																																												}
																																																																																											}
																																																																																										}
																																																																																									}
																																																																																								}
																																																																																							}
																																																																																						}
																																																																																					}
																																																																																				}
																																																																																			}
																																																																																		}
																																																																																	}
																																																																																}
																																																																															}
																																																																														}
																																																																													}
																																																																												}
																																																																											}
																																																																										}
																																																																									}
																																																																								}
																																																																							}
																																																																						}
																																																																					}
																																																																				}
																																																																			}
																																																																		}
																																																																	}
																																																																}
																																																															}
																																																														}
																																																													}
																																																												}
																																																											}
																																																										}
																																																									}
																																																								}
																																																							}
																																																						}
																																																					}
																																																				}
																																																			}
																																																		}
																																																	}
																																																}
																																															}
																																														}
																																													}
																																												}
																																											}
																																										}
																																									}
																																								}
																																							}
																																						}
																																					}
																																				}
																																			}
																																		}
																																	}
																																}
																															}
																														}
																													}
																												}
																											}
																										}
																									}
																								}
																							}
																						}
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			if (this.type == 122)
			{
				this.name = "Molten Pickaxe";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 25;
				this.useTime = 25;
				this.autoReuse = true;
				this.width = 24;
				this.height = 28;
				this.damage = 12;
				this.pick = 100;
				this.scale = 1.15f;
				this.useSound = 1;
				this.knockBack = 2f;
				this.rare = 3;
				this.value = 27000;
				this.melee = true;
			}
			else
			{
				if (this.type == 123)
				{
					this.name = "Meteor Helmet";
					this.width = 18;
					this.height = 18;
					this.defense = 3;
					this.headSlot = 6;
					this.rare = 1;
					this.value = 45000;
					this.toolTip = "%5 increased magic damage";
				}
				else
				{
					if (this.type == 124)
					{
						this.name = "Meteor Suit";
						this.width = 18;
						this.height = 18;
						this.defense = 4;
						this.bodySlot = 6;
						this.rare = 1;
						this.value = 30000;
						this.toolTip = "%5 increased magic damage";
					}
					else
					{
						if (this.type == 125)
						{
							this.name = "Meteor Leggings";
							this.width = 18;
							this.height = 18;
							this.defense = 3;
							this.legSlot = 6;
							this.rare = 1;
							this.value = 30000;
							this.toolTip = "%5 increased magic damage";
						}
						else
						{
							if (this.type == 126)
							{
								this.name = "Bottled Water";
								this.useSound = 3;
								this.healLife = 20;
								this.useStyle = 2;
								this.useTurn = true;
								this.useAnimation = 17;
								this.useTime = 17;
								this.maxStack = 30;
								this.consumable = true;
								this.width = 14;
								this.height = 24;
								this.potion = true;
								this.value = 20;
							}
							else
							{
								if (this.type == 127)
								{
									this.autoReuse = true;
									this.useStyle = 5;
									this.useAnimation = 19;
									this.useTime = 19;
									this.name = "Space Gun";
									this.width = 24;
									this.height = 28;
									this.shoot = 20;
									this.mana = 8;
									this.useSound = 12;
									this.knockBack = 0.5f;
									this.damage = 17;
									this.shootSpeed = 10f;
									this.noMelee = true;
									this.scale = 0.8f;
									this.rare = 1;
									this.magic = true;
								}
								else
								{
									if (this.type == 128)
									{
										this.name = "Rocket Boots";
										this.width = 28;
										this.height = 24;
										this.accessory = true;
										this.rare = 3;
										this.toolTip = "Allows flight";
										this.value = 50000;
									}
									else
									{
										if (this.type == 129)
										{
											this.name = "Gray Brick";
											this.useStyle = 1;
											this.useTurn = true;
											this.useAnimation = 15;
											this.useTime = 10;
											this.autoReuse = true;
											this.maxStack = 250;
											this.consumable = true;
											this.createTile = 38;
											this.width = 12;
											this.height = 12;
										}
										else
										{
											if (this.type == 130)
											{
												this.name = "Gray Brick Wall";
												this.useStyle = 1;
												this.useTurn = true;
												this.useAnimation = 15;
												this.useTime = 7;
												this.autoReuse = true;
												this.maxStack = 250;
												this.consumable = true;
												this.createWall = 5;
												this.width = 12;
												this.height = 12;
											}
											else
											{
												if (this.type == 131)
												{
													this.name = "Red Brick";
													this.useStyle = 1;
													this.useTurn = true;
													this.useAnimation = 15;
													this.useTime = 10;
													this.autoReuse = true;
													this.maxStack = 250;
													this.consumable = true;
													this.createTile = 39;
													this.width = 12;
													this.height = 12;
												}
												else
												{
													if (this.type == 132)
													{
														this.name = "Red Brick Wall";
														this.useStyle = 1;
														this.useTurn = true;
														this.useAnimation = 15;
														this.useTime = 7;
														this.autoReuse = true;
														this.maxStack = 250;
														this.consumable = true;
														this.createWall = 6;
														this.width = 12;
														this.height = 12;
													}
													else
													{
														if (this.type == 133)
														{
															this.name = "Clay Block";
															this.useStyle = 1;
															this.useTurn = true;
															this.useAnimation = 15;
															this.useTime = 10;
															this.autoReuse = true;
															this.maxStack = 250;
															this.consumable = true;
															this.createTile = 40;
															this.width = 12;
															this.height = 12;
														}
														else
														{
															if (this.type == 134)
															{
																this.name = "Blue Brick";
																this.useStyle = 1;
																this.useTurn = true;
																this.useAnimation = 15;
																this.useTime = 10;
																this.autoReuse = true;
																this.maxStack = 250;
																this.consumable = true;
																this.createTile = 41;
																this.width = 12;
																this.height = 12;
															}
															else
															{
																if (this.type == 135)
																{
																	this.name = "Blue Brick Wall";
																	this.useStyle = 1;
																	this.useTurn = true;
																	this.useAnimation = 15;
																	this.useTime = 7;
																	this.autoReuse = true;
																	this.maxStack = 250;
																	this.consumable = true;
																	this.createWall = 17;
																	this.width = 12;
																	this.height = 12;
																}
																else
																{
																	if (this.type == 136)
																	{
																		this.name = "Chain Lantern";
																		this.useStyle = 1;
																		this.useTurn = true;
																		this.useAnimation = 15;
																		this.useTime = 10;
																		this.autoReuse = true;
																		this.maxStack = 250;
																		this.consumable = true;
																		this.createTile = 42;
																		this.width = 12;
																		this.height = 28;
																	}
																	else
																	{
																		if (this.type == 137)
																		{
																			this.name = "Green Brick";
																			this.useStyle = 1;
																			this.useTurn = true;
																			this.useAnimation = 15;
																			this.useTime = 10;
																			this.autoReuse = true;
																			this.maxStack = 250;
																			this.consumable = true;
																			this.createTile = 43;
																			this.width = 12;
																			this.height = 12;
																		}
																		else
																		{
																			if (this.type == 138)
																			{
																				this.name = "Green Brick Wall";
																				this.useStyle = 1;
																				this.useTurn = true;
																				this.useAnimation = 15;
																				this.useTime = 7;
																				this.autoReuse = true;
																				this.maxStack = 250;
																				this.consumable = true;
																				this.createWall = 18;
																				this.width = 12;
																				this.height = 12;
																			}
																			else
																			{
																				if (this.type == 139)
																				{
																					this.name = "Pink Brick";
																					this.useStyle = 1;
																					this.useTurn = true;
																					this.useAnimation = 15;
																					this.useTime = 10;
																					this.autoReuse = true;
																					this.maxStack = 250;
																					this.consumable = true;
																					this.createTile = 44;
																					this.width = 12;
																					this.height = 12;
																				}
																				else
																				{
																					if (this.type == 140)
																					{
																						this.name = "Pink Brick Wall";
																						this.useStyle = 1;
																						this.useTurn = true;
																						this.useAnimation = 15;
																						this.useTime = 7;
																						this.autoReuse = true;
																						this.maxStack = 250;
																						this.consumable = true;
																						this.createWall = 19;
																						this.width = 12;
																						this.height = 12;
																					}
																					else
																					{
																						if (this.type == 141)
																						{
																							this.name = "Gold Brick";
																							this.useStyle = 1;
																							this.useTurn = true;
																							this.useAnimation = 15;
																							this.useTime = 10;
																							this.autoReuse = true;
																							this.maxStack = 250;
																							this.consumable = true;
																							this.createTile = 45;
																							this.width = 12;
																							this.height = 12;
																						}
																						else
																						{
																							if (this.type == 142)
																							{
																								this.name = "Gold Brick Wall";
																								this.useStyle = 1;
																								this.useTurn = true;
																								this.useAnimation = 15;
																								this.useTime = 7;
																								this.autoReuse = true;
																								this.maxStack = 250;
																								this.consumable = true;
																								this.createWall = 10;
																								this.width = 12;
																								this.height = 12;
																							}
																							else
																							{
																								if (this.type == 143)
																								{
																									this.name = "Silver Brick";
																									this.useStyle = 1;
																									this.useTurn = true;
																									this.useAnimation = 15;
																									this.useTime = 10;
																									this.autoReuse = true;
																									this.maxStack = 250;
																									this.consumable = true;
																									this.createTile = 46;
																									this.width = 12;
																									this.height = 12;
																								}
																								else
																								{
																									if (this.type == 144)
																									{
																										this.name = "Silver Brick Wall";
																										this.useStyle = 1;
																										this.useTurn = true;
																										this.useAnimation = 15;
																										this.useTime = 7;
																										this.autoReuse = true;
																										this.maxStack = 250;
																										this.consumable = true;
																										this.createWall = 11;
																										this.width = 12;
																										this.height = 12;
																									}
																									else
																									{
																										if (this.type == 145)
																										{
																											this.name = "Copper Brick";
																											this.useStyle = 1;
																											this.useTurn = true;
																											this.useAnimation = 15;
																											this.useTime = 10;
																											this.autoReuse = true;
																											this.maxStack = 250;
																											this.consumable = true;
																											this.createTile = 47;
																											this.width = 12;
																											this.height = 12;
																										}
																										else
																										{
																											if (this.type == 146)
																											{
																												this.name = "Copper Brick Wall";
																												this.useStyle = 1;
																												this.useTurn = true;
																												this.useAnimation = 15;
																												this.useTime = 7;
																												this.autoReuse = true;
																												this.maxStack = 250;
																												this.consumable = true;
																												this.createWall = 12;
																												this.width = 12;
																												this.height = 12;
																											}
																											else
																											{
																												if (this.type == 147)
																												{
																													this.name = "Spike";
																													this.useStyle = 1;
																													this.useTurn = true;
																													this.useAnimation = 15;
																													this.useTime = 10;
																													this.autoReuse = true;
																													this.maxStack = 250;
																													this.consumable = true;
																													this.createTile = 48;
																													this.width = 12;
																													this.height = 12;
																												}
																												else
																												{
																													if (this.type == 148)
																													{
																														this.noWet = true;
																														this.name = "Water Candle";
																														this.useStyle = 1;
																														this.useTurn = true;
																														this.useAnimation = 15;
																														this.useTime = 10;
																														this.autoReuse = true;
																														this.maxStack = 99;
																														this.consumable = true;
																														this.createTile = 49;
																														this.width = 8;
																														this.height = 18;
																														this.holdStyle = 1;
																														this.toolTip = "Holding this may attract unwanted attention";
																													}
																													else
																													{
																														if (this.type == 149)
																														{
																															this.name = "Book";
																															this.useStyle = 1;
																															this.useTurn = true;
																															this.useAnimation = 15;
																															this.useTime = 10;
																															this.autoReuse = true;
																															this.maxStack = 99;
																															this.consumable = true;
																															this.createTile = 50;
																															this.width = 24;
																															this.height = 28;
																															this.toolTip = "'It contains strange symbols'";
																														}
																														else
																														{
																															if (this.type == 150)
																															{
																																this.name = "Cobweb";
																																this.useStyle = 1;
																																this.useTurn = true;
																																this.useAnimation = 15;
																																this.useTime = 10;
																																this.autoReuse = true;
																																this.maxStack = 250;
																																this.consumable = true;
																																this.createTile = 51;
																																this.width = 20;
																																this.height = 24;
																																this.alpha = 100;
																															}
																															else
																															{
																																if (this.type == 151)
																																{
																																	this.name = "Necro Helmet";
																																	this.width = 18;
																																	this.height = 18;
																																	this.defense = 5;
																																	this.headSlot = 7;
																																	this.rare = 2;
																																	this.value = 45000;
																																	this.toolTip = "4% increased ranged damage.";
																																}
																																else
																																{
																																	if (this.type == 152)
																																	{
																																		this.name = "Necro Breastplate";
																																		this.width = 18;
																																		this.height = 18;
																																		this.defense = 6;
																																		this.bodySlot = 7;
																																		this.rare = 2;
																																		this.value = 30000;
																																		this.toolTip = "4% increased ranged damage.";
																																	}
																																	else
																																	{
																																		if (this.type == 153)
																																		{
																																			this.name = "Necro Greaves";
																																			this.width = 18;
																																			this.height = 18;
																																			this.defense = 5;
																																			this.legSlot = 7;
																																			this.rare = 2;
																																			this.value = 30000;
																																			this.toolTip = "4% increased ranged damage.";
																																		}
																																		else
																																		{
																																			if (this.type == 154)
																																			{
																																				this.name = "Bone";
																																				this.maxStack = 99;
																																				this.consumable = true;
																																				this.width = 12;
																																				this.height = 14;
																																				this.value = 50;
																																				this.useAnimation = 12;
																																				this.useTime = 12;
																																				this.useStyle = 1;
																																				this.useSound = 1;
																																				this.shootSpeed = 8f;
																																				this.noUseGraphic = true;
																																				this.damage = 22;
																																				this.knockBack = 4f;
																																				this.shoot = 21;
																																				this.ranged = true;
																																			}
																																			else
																																			{
																																				if (this.type == 155)
																																				{
																																					this.autoReuse = true;
																																					this.useTurn = true;
																																					this.name = "Muramasa";
																																					this.useStyle = 1;
																																					this.useAnimation = 20;
																																					this.width = 40;
																																					this.height = 40;
																																					this.damage = 18;
																																					this.scale = 1.1f;
																																					this.useSound = 1;
																																					this.rare = 2;
																																					this.value = 27000;
																																					this.knockBack = 1f;
																																					this.melee = true;
																																				}
																																				else
																																				{
																																					if (this.type == 156)
																																					{
																																						this.name = "Cobalt Shield";
																																						this.width = 24;
																																						this.height = 28;
																																						this.rare = 2;
																																						this.value = 27000;
																																						this.accessory = true;
																																						this.defense = 1;
																																						this.toolTip = "Grants immunity to knockback";
																																					}
																																					else
																																					{
																																						if (this.type == 157)
																																						{
																																							this.mana = 7;
																																							this.autoReuse = true;
																																							this.name = "Aqua Scepter";
																																							this.useStyle = 5;
																																							this.useAnimation = 16;
																																							this.useTime = 8;
																																							this.knockBack = 5f;
																																							this.width = 38;
																																							this.height = 10;
																																							this.damage = 14;
																																							this.scale = 1f;
																																							this.shoot = 22;
																																							this.shootSpeed = 11f;
																																							this.useSound = 13;
																																							this.rare = 2;
																																							this.value = 27000;
																																							this.toolTip = "Sprays out a shower of water";
																																							this.magic = true;
																																						}
																																						else
																																						{
																																							if (this.type == 158)
																																							{
																																								this.name = "Lucky Horseshoe";
																																								this.width = 20;
																																								this.height = 22;
																																								this.rare = 1;
																																								this.value = 27000;
																																								this.accessory = true;
																																								this.toolTip = "Negate fall damage";
																																							}
																																							else
																																							{
																																								if (this.type == 159)
																																								{
																																									this.name = "Shiny Red Balloon";
																																									this.width = 14;
																																									this.height = 28;
																																									this.rare = 1;
																																									this.value = 27000;
																																									this.accessory = true;
																																									this.toolTip = "Increases jump height";
																																								}
																																								else
																																								{
																																									if (this.type == 160)
																																									{
																																										this.autoReuse = true;
																																										this.name = "Harpoon";
																																										this.useStyle = 5;
																																										this.useAnimation = 30;
																																										this.useTime = 30;
																																										this.knockBack = 6f;
																																										this.width = 30;
																																										this.height = 10;
																																										this.damage = 25;
																																										this.scale = 1.1f;
																																										this.shoot = 23;
																																										this.shootSpeed = 11f;
																																										this.useSound = 10;
																																										this.rare = 2;
																																										this.value = 27000;
																																										this.ranged = true;
																																									}
																																									else
																																									{
																																										if (this.type == 161)
																																										{
																																											this.useStyle = 1;
																																											this.name = "Spiky Ball";
																																											this.shootSpeed = 5f;
																																											this.shoot = 24;
																																											this.knockBack = 1f;
																																											this.damage = 15;
																																											this.width = 10;
																																											this.height = 10;
																																											this.maxStack = 250;
																																											this.consumable = true;
																																											this.useSound = 1;
																																											this.useAnimation = 15;
																																											this.useTime = 15;
																																											this.noUseGraphic = true;
																																											this.noMelee = true;
																																											this.value = 20;
																																											this.ranged = true;
																																										}
																																										else
																																										{
																																											if (this.type == 162)
																																											{
																																												this.name = "Ball O' Hurt";
																																												this.useStyle = 5;
																																												this.useAnimation = 45;
																																												this.useTime = 45;
																																												this.knockBack = 6.5f;
																																												this.width = 30;
																																												this.height = 10;
																																												this.damage = 15;
																																												this.scale = 1.1f;
																																												this.noUseGraphic = true;
																																												this.shoot = 25;
																																												this.shootSpeed = 12f;
																																												this.useSound = 1;
																																												this.rare = 1;
																																												this.value = 27000;
																																												this.melee = true;
																																												this.channel = true;
																																												this.noMelee = true;
																																											}
																																											else
																																											{
																																												if (this.type == 163)
																																												{
																																													this.name = "Blue Moon";
																																													this.useStyle = 5;
																																													this.useAnimation = 45;
																																													this.useTime = 45;
																																													this.knockBack = 7f;
																																													this.width = 30;
																																													this.height = 10;
																																													this.damage = 23;
																																													this.scale = 1.1f;
																																													this.noUseGraphic = true;
																																													this.shoot = 26;
																																													this.shootSpeed = 12f;
																																													this.useSound = 1;
																																													this.rare = 2;
																																													this.value = 27000;
																																													this.melee = true;
																																													this.channel = true;
																																												}
																																												else
																																												{
																																													if (this.type == 164)
																																													{
																																														this.autoReuse = false;
																																														this.useStyle = 5;
																																														this.useAnimation = 12;
																																														this.useTime = 12;
																																														this.name = "Handgun";
																																														this.width = 24;
																																														this.height = 24;
																																														this.shoot = 14;
																																														this.knockBack = 3f;
																																														this.useAmmo = 14;
																																														this.useSound = 11;
																																														this.damage = 14;
																																														this.shootSpeed = 10f;
																																														this.noMelee = true;
																																														this.value = 50000;
																																														this.scale = 0.75f;
																																														this.rare = 2;
																																														this.ranged = true;
																																													}
																																													else
																																													{
																																														if (this.type == 165)
																																														{
																																															this.autoReuse = true;
																																															this.rare = 2;
																																															this.mana = 14;
																																															this.useSound = 21;
																																															this.name = "Water Bolt";
																																															this.useStyle = 5;
																																															this.damage = 17;
																																															this.useAnimation = 17;
																																															this.useTime = 17;
																																															this.width = 24;
																																															this.height = 28;
																																															this.shoot = 27;
																																															this.scale = 0.9f;
																																															this.shootSpeed = 4.5f;
																																															this.knockBack = 5f;
																																															this.toolTip = "Casts a slow moving bolt of water";
																																															this.magic = true;
																																														}
																																														else
																																														{
																																															if (this.type == 166)
																																															{
																																																this.useStyle = 1;
																																																this.name = "Bomb";
																																																this.shootSpeed = 5f;
																																																this.shoot = 28;
																																																this.width = 20;
																																																this.height = 20;
																																																this.maxStack = 20;
																																																this.consumable = true;
																																																this.useSound = 1;
																																																this.useAnimation = 25;
																																																this.useTime = 25;
																																																this.noUseGraphic = true;
																																																this.noMelee = true;
																																																this.value = 500;
																																																this.damage = 0;
																																																this.toolTip = "A small explosion that will destroy some tiles";
																																															}
																																															else
																																															{
																																																if (this.type == 167)
																																																{
																																																	this.useStyle = 1;
																																																	this.name = "Dynamite";
																																																	this.shootSpeed = 4f;
																																																	this.shoot = 29;
																																																	this.width = 8;
																																																	this.height = 28;
																																																	this.maxStack = 3;
																																																	this.consumable = true;
																																																	this.useSound = 1;
																																																	this.useAnimation = 40;
																																																	this.useTime = 40;
																																																	this.noUseGraphic = true;
																																																	this.noMelee = true;
																																																	this.value = 5000;
																																																	this.rare = 1;
																																																	this.toolTip = "A large explosion that will destroy most tiles";
																																																}
																																																else
																																																{
																																																	if (this.type == 168)
																																																	{
																																																		this.useStyle = 5;
																																																		this.name = "Grenade";
																																																		this.shootSpeed = 5.5f;
																																																		this.shoot = 30;
																																																		this.width = 20;
																																																		this.height = 20;
																																																		this.maxStack = 20;
																																																		this.consumable = true;
																																																		this.useSound = 1;
																																																		this.useAnimation = 45;
																																																		this.useTime = 45;
																																																		this.noUseGraphic = true;
																																																		this.noMelee = true;
																																																		this.value = 400;
																																																		this.damage = 60;
																																																		this.knockBack = 8f;
																																																		this.toolTip = "A small explosion that will not destroy tiles";
																																																		this.ranged = true;
																																																	}
																																																	else
																																																	{
																																																		if (this.type == 169)
																																																		{
																																																			this.name = "Sand Block";
																																																			this.useStyle = 1;
																																																			this.useTurn = true;
																																																			this.useAnimation = 15;
																																																			this.useTime = 10;
																																																			this.autoReuse = true;
																																																			this.maxStack = 250;
																																																			this.consumable = true;
																																																			this.createTile = 53;
																																																			this.width = 12;
																																																			this.height = 12;
																																																			this.ammo = 42;
																																																		}
																																																		else
																																																		{
																																																			if (this.type == 170)
																																																			{
																																																				this.name = "Glass";
																																																				this.useStyle = 1;
																																																				this.useTurn = true;
																																																				this.useAnimation = 15;
																																																				this.useTime = 10;
																																																				this.autoReuse = true;
																																																				this.maxStack = 250;
																																																				this.consumable = true;
																																																				this.createTile = 54;
																																																				this.width = 12;
																																																				this.height = 12;
																																																			}
																																																			else
																																																			{
																																																				if (this.type == 171)
																																																				{
																																																					this.name = "Sign";
																																																					this.useStyle = 1;
																																																					this.useTurn = true;
																																																					this.useAnimation = 15;
																																																					this.useTime = 10;
																																																					this.autoReuse = true;
																																																					this.maxStack = 250;
																																																					this.consumable = true;
																																																					this.createTile = 55;
																																																					this.width = 28;
																																																					this.height = 28;
																																																				}
																																																				else
																																																				{
																																																					if (this.type == 172)
																																																					{
																																																						this.name = "Ash Block";
																																																						this.useStyle = 1;
																																																						this.useTurn = true;
																																																						this.useAnimation = 15;
																																																						this.useTime = 10;
																																																						this.autoReuse = true;
																																																						this.maxStack = 250;
																																																						this.consumable = true;
																																																						this.createTile = 57;
																																																						this.width = 12;
																																																						this.height = 12;
																																																					}
																																																					else
																																																					{
																																																						if (this.type == 173)
																																																						{
																																																							this.name = "Obsidian";
																																																							this.useStyle = 1;
																																																							this.useTurn = true;
																																																							this.useAnimation = 15;
																																																							this.useTime = 10;
																																																							this.autoReuse = true;
																																																							this.maxStack = 250;
																																																							this.consumable = true;
																																																							this.createTile = 56;
																																																							this.width = 12;
																																																							this.height = 12;
																																																						}
																																																						else
																																																						{
																																																							if (this.type == 174)
																																																							{
																																																								this.name = "Hellstone";
																																																								this.useStyle = 1;
																																																								this.useTurn = true;
																																																								this.useAnimation = 15;
																																																								this.useTime = 10;
																																																								this.autoReuse = true;
																																																								this.maxStack = 250;
																																																								this.consumable = true;
																																																								this.createTile = 58;
																																																								this.width = 12;
																																																								this.height = 12;
																																																							}
																																																							else
																																																							{
																																																								if (this.type == 175)
																																																								{
																																																									this.name = "Hellstone Bar";
																																																									this.width = 20;
																																																									this.height = 20;
																																																									this.maxStack = 99;
																																																									this.rare = 2;
																																																									this.toolTip = "'Hot to the touch'";
																																																									this.value = 20000;
																																																								}
																																																								else
																																																								{
																																																									if (this.type == 176)
																																																									{
																																																										this.name = "Mud Block";
																																																										this.useStyle = 1;
																																																										this.useTurn = true;
																																																										this.useAnimation = 15;
																																																										this.useTime = 10;
																																																										this.autoReuse = true;
																																																										this.maxStack = 250;
																																																										this.consumable = true;
																																																										this.createTile = 59;
																																																										this.width = 12;
																																																										this.height = 12;
																																																									}
																																																									else
																																																									{
																																																										if (this.type == 181)
																																																										{
																																																											this.name = "Amethyst";
																																																											this.maxStack = 99;
																																																											this.alpha = 50;
																																																											this.width = 10;
																																																											this.height = 14;
																																																											this.value = 1875;
																																																										}
																																																										else
																																																										{
																																																											if (this.type == 180)
																																																											{
																																																												this.name = "Topaz";
																																																												this.maxStack = 99;
																																																												this.alpha = 50;
																																																												this.width = 10;
																																																												this.height = 14;
																																																												this.value = 3750;
																																																											}
																																																											else
																																																											{
																																																												if (this.type == 177)
																																																												{
																																																													this.name = "Sapphire";
																																																													this.maxStack = 99;
																																																													this.alpha = 50;
																																																													this.width = 10;
																																																													this.height = 14;
																																																													this.value = 5625;
																																																												}
																																																												else
																																																												{
																																																													if (this.type == 179)
																																																													{
																																																														this.name = "Emerald";
																																																														this.maxStack = 99;
																																																														this.alpha = 50;
																																																														this.width = 10;
																																																														this.height = 14;
																																																														this.value = 7500;
																																																													}
																																																													else
																																																													{
																																																														if (this.type == 178)
																																																														{
																																																															this.name = "Ruby";
																																																															this.maxStack = 99;
																																																															this.alpha = 50;
																																																															this.width = 10;
																																																															this.height = 14;
																																																															this.value = 11250;
																																																														}
																																																														else
																																																														{
																																																															if (this.type == 182)
																																																															{
																																																																this.name = "Diamond";
																																																																this.maxStack = 99;
																																																																this.alpha = 50;
																																																																this.width = 10;
																																																																this.height = 14;
																																																																this.value = 15000;
																																																															}
																																																															else
																																																															{
																																																																if (this.type == 183)
																																																																{
																																																																	this.name = "Glowing Mushroom";
																																																																	this.useStyle = 2;
																																																																	this.useSound = 2;
																																																																	this.useTurn = false;
																																																																	this.useAnimation = 17;
																																																																	this.useTime = 17;
																																																																	this.width = 16;
																																																																	this.height = 18;
																																																																	this.healLife = 25;
																																																																	this.maxStack = 99;
																																																																	this.consumable = true;
																																																																	this.potion = true;
																																																																	this.value = 50;
																																																																}
																																																																else
																																																																{
																																																																	if (this.type == 184)
																																																																	{
																																																																		this.name = "Star";
																																																																		this.width = 12;
																																																																		this.height = 12;
																																																																	}
																																																																	else
																																																																	{
																																																																		if (this.type == 185)
																																																																		{
																																																																			this.noUseGraphic = true;
																																																																			this.damage = 0;
																																																																			this.knockBack = 7f;
																																																																			this.useStyle = 5;
																																																																			this.name = "Ivy Whip";
																																																																			this.shootSpeed = 13f;
																																																																			this.shoot = 32;
																																																																			this.width = 18;
																																																																			this.height = 28;
																																																																			this.useSound = 1;
																																																																			this.useAnimation = 20;
																																																																			this.useTime = 20;
																																																																			this.rare = 3;
																																																																			this.noMelee = true;
																																																																			this.value = 20000;
																																																																		}
																																																																		else
																																																																		{
																																																																			if (this.type == 186)
																																																																			{
																																																																				this.name = "Breathing Reed";
																																																																				this.width = 44;
																																																																				this.height = 44;
																																																																				this.rare = 1;
																																																																				this.value = 10000;
																																																																				this.holdStyle = 2;
																																																																				this.toolTip = "'Because not drowning is kinda nice'";
																																																																			}
																																																																			else
																																																																			{
																																																																				if (this.type == 187)
																																																																				{
																																																																					this.name = "Flipper";
																																																																					this.width = 28;
																																																																					this.height = 28;
																																																																					this.rare = 1;
																																																																					this.value = 10000;
																																																																					this.accessory = true;
																																																																					this.toolTip = "Grants the ability to swim";
																																																																				}
																																																																				else
																																																																				{
																																																																					if (this.type == 188)
																																																																					{
																																																																						this.name = "Healing Potion";
																																																																						this.useSound = 3;
																																																																						this.healLife = 100;
																																																																						this.useStyle = 2;
																																																																						this.useTurn = true;
																																																																						this.useAnimation = 17;
																																																																						this.useTime = 17;
																																																																						this.maxStack = 30;
																																																																						this.consumable = true;
																																																																						this.width = 14;
																																																																						this.height = 24;
																																																																						this.rare = 1;
																																																																						this.potion = true;
																																																																						this.value = 1000;
																																																																					}
																																																																					else
																																																																					{
																																																																						if (this.type == 189)
																																																																						{
																																																																							this.name = "Mana Potion";
																																																																							this.useSound = 3;
																																																																							this.healMana = 100;
																																																																							this.useStyle = 2;
																																																																							this.useTurn = true;
																																																																							this.useAnimation = 17;
																																																																							this.useTime = 17;
																																																																							this.maxStack = 30;
																																																																							this.consumable = true;
																																																																							this.width = 14;
																																																																							this.height = 24;
																																																																							this.rare = 1;
																																																																							this.value = 1000;
																																																																						}
																																																																						else
																																																																						{
																																																																							if (this.type == 190)
																																																																							{
																																																																								this.name = "Blade of Grass";
																																																																								this.useStyle = 1;
																																																																								this.useAnimation = 30;
																																																																								this.knockBack = 3f;
																																																																								this.width = 40;
																																																																								this.height = 40;
																																																																								this.damage = 28;
																																																																								this.scale = 1.4f;
																																																																								this.useSound = 1;
																																																																								this.rare = 3;
																																																																								this.value = 27000;
																																																																								this.melee = true;
																																																																							}
																																																																							else
																																																																							{
																																																																								if (this.type == 191)
																																																																								{
																																																																									this.noMelee = true;
																																																																									this.useStyle = 1;
																																																																									this.name = "Thorn Chakram";
																																																																									this.shootSpeed = 11f;
																																																																									this.shoot = 33;
																																																																									this.damage = 25;
																																																																									this.knockBack = 8f;
																																																																									this.width = 14;
																																																																									this.height = 28;
																																																																									this.useSound = 1;
																																																																									this.useAnimation = 15;
																																																																									this.useTime = 15;
																																																																									this.noUseGraphic = true;
																																																																									this.rare = 3;
																																																																									this.value = 50000;
																																																																									this.ranged = true;
																																																																								}
																																																																								else
																																																																								{
																																																																									if (this.type == 192)
																																																																									{
																																																																										this.name = "Obsidian Brick";
																																																																										this.useStyle = 1;
																																																																										this.useTurn = true;
																																																																										this.useAnimation = 15;
																																																																										this.useTime = 10;
																																																																										this.autoReuse = true;
																																																																										this.maxStack = 250;
																																																																										this.consumable = true;
																																																																										this.createTile = 75;
																																																																										this.width = 12;
																																																																										this.height = 12;
																																																																									}
																																																																									else
																																																																									{
																																																																										if (this.type == 193)
																																																																										{
																																																																											this.name = "Obsidian Skull";
																																																																											this.width = 20;
																																																																											this.height = 22;
																																																																											this.rare = 2;
																																																																											this.value = 27000;
																																																																											this.accessory = true;
																																																																											this.defense = 1;
																																																																											this.toolTip = "Grants immunity to fire blocks";
																																																																										}
																																																																										else
																																																																										{
																																																																											if (this.type == 194)
																																																																											{
																																																																												this.name = "Mushroom Grass Seeds";
																																																																												this.useTurn = true;
																																																																												this.useStyle = 1;
																																																																												this.useAnimation = 15;
																																																																												this.useTime = 10;
																																																																												this.maxStack = 99;
																																																																												this.consumable = true;
																																																																												this.createTile = 70;
																																																																												this.width = 14;
																																																																												this.height = 14;
																																																																												this.value = 150;
																																																																											}
																																																																											else
																																																																											{
																																																																												if (this.type == 195)
																																																																												{
																																																																													this.name = "Jungle Grass Seeds";
																																																																													this.useTurn = true;
																																																																													this.useStyle = 1;
																																																																													this.useAnimation = 15;
																																																																													this.useTime = 10;
																																																																													this.maxStack = 99;
																																																																													this.consumable = true;
																																																																													this.createTile = 60;
																																																																													this.width = 14;
																																																																													this.height = 14;
																																																																													this.value = 150;
																																																																												}
																																																																												else
																																																																												{
																																																																													if (this.type == 196)
																																																																													{
																																																																														this.name = "Wooden Hammer";
																																																																														this.autoReuse = true;
																																																																														this.useStyle = 1;
																																																																														this.useTurn = true;
																																																																														this.useAnimation = 37;
																																																																														this.useTime = 25;
																																																																														this.hammer = 25;
																																																																														this.width = 24;
																																																																														this.height = 28;
																																																																														this.damage = 2;
																																																																														this.knockBack = 5.5f;
																																																																														this.scale = 1.2f;
																																																																														this.useSound = 1;
																																																																														this.tileBoost = -1;
																																																																														this.value = 50;
																																																																														this.melee = true;
																																																																													}
																																																																													else
																																																																													{
																																																																														if (this.type == 197)
																																																																														{
																																																																															this.autoReuse = true;
																																																																															this.useStyle = 5;
																																																																															this.useAnimation = 40;
																																																																															this.useTime = 40;
																																																																															this.name = "Star Cannon";
																																																																															this.width = 50;
																																																																															this.height = 18;
																																																																															this.shoot = 12;
																																																																															this.useAmmo = 15;
																																																																															this.useSound = 9;
																																																																															this.damage = 60;
																																																																															this.shootSpeed = 14f;
																																																																															this.noMelee = true;
																																																																															this.value = 500000;
																																																																															this.rare = 2;
																																																																															this.toolTip = "Shoots fallen stars";
																																																																															this.ranged = true;
																																																																														}
																																																																														else
																																																																														{
																																																																															if (this.type == 198)
																																																																															{
																																																																																this.name = "Blue Phaseblade";
																																																																																this.useStyle = 1;
																																																																																this.useAnimation = 25;
																																																																																this.knockBack = 3f;
																																																																																this.width = 40;
																																																																																this.height = 40;
																																																																																this.damage = 21;
																																																																																this.scale = 1f;
																																																																																this.useSound = 15;
																																																																																this.rare = 1;
																																																																																this.value = 27000;
																																																																																this.melee = true;
																																																																															}
																																																																															else
																																																																															{
																																																																																if (this.type == 199)
																																																																																{
																																																																																	this.name = "Red Phaseblade";
																																																																																	this.useStyle = 1;
																																																																																	this.useAnimation = 25;
																																																																																	this.knockBack = 3f;
																																																																																	this.width = 40;
																																																																																	this.height = 40;
																																																																																	this.damage = 21;
																																																																																	this.scale = 1f;
																																																																																	this.useSound = 15;
																																																																																	this.rare = 1;
																																																																																	this.value = 27000;
																																																																																	this.melee = true;
																																																																																}
																																																																																else
																																																																																{
																																																																																	if (this.type == 200)
																																																																																	{
																																																																																		this.name = "Green Phaseblade";
																																																																																		this.useStyle = 1;
																																																																																		this.useAnimation = 25;
																																																																																		this.knockBack = 3f;
																																																																																		this.width = 40;
																																																																																		this.height = 40;
																																																																																		this.damage = 21;
																																																																																		this.scale = 1f;
																																																																																		this.useSound = 15;
																																																																																		this.rare = 1;
																																																																																		this.value = 27000;
																																																																																		this.melee = true;
																																																																																	}
																																																																																	else
																																																																																	{
																																																																																		if (this.type == 201)
																																																																																		{
																																																																																			this.name = "Purple Phaseblade";
																																																																																			this.useStyle = 1;
																																																																																			this.useAnimation = 25;
																																																																																			this.knockBack = 3f;
																																																																																			this.width = 40;
																																																																																			this.height = 40;
																																																																																			this.damage = 21;
																																																																																			this.scale = 1f;
																																																																																			this.useSound = 15;
																																																																																			this.rare = 1;
																																																																																			this.value = 27000;
																																																																																			this.melee = true;
																																																																																		}
																																																																																		else
																																																																																		{
																																																																																			if (this.type == 202)
																																																																																			{
																																																																																				this.name = "White Phaseblade";
																																																																																				this.useStyle = 1;
																																																																																				this.useAnimation = 25;
																																																																																				this.knockBack = 3f;
																																																																																				this.width = 40;
																																																																																				this.height = 40;
																																																																																				this.damage = 21;
																																																																																				this.scale = 1f;
																																																																																				this.useSound = 15;
																																																																																				this.rare = 1;
																																																																																				this.value = 27000;
																																																																																				this.melee = true;
																																																																																			}
																																																																																			else
																																																																																			{
																																																																																				if (this.type == 203)
																																																																																				{
																																																																																					this.name = "Yellow Phaseblade";
																																																																																					this.useStyle = 1;
																																																																																					this.useAnimation = 25;
																																																																																					this.knockBack = 3f;
																																																																																					this.width = 40;
																																																																																					this.height = 40;
																																																																																					this.damage = 21;
																																																																																					this.scale = 1f;
																																																																																					this.useSound = 15;
																																																																																					this.rare = 1;
																																																																																					this.value = 27000;
																																																																																					this.melee = true;
																																																																																				}
																																																																																				else
																																																																																				{
																																																																																					if (this.type == 204)
																																																																																					{
																																																																																						this.name = "Meteor Hamaxe";
																																																																																						this.useTurn = true;
																																																																																						this.autoReuse = true;
																																																																																						this.useStyle = 1;
																																																																																						this.useAnimation = 30;
																																																																																						this.useTime = 16;
																																																																																						this.hammer = 60;
																																																																																						this.axe = 20;
																																																																																						this.width = 24;
																																																																																						this.height = 28;
																																																																																						this.damage = 20;
																																																																																						this.knockBack = 7f;
																																																																																						this.scale = 1.2f;
																																																																																						this.useSound = 1;
																																																																																						this.rare = 1;
																																																																																						this.value = 15000;
																																																																																						this.melee = true;
																																																																																					}
																																																																																					else
																																																																																					{
																																																																																						if (this.type == 205)
																																																																																						{
																																																																																							this.name = "Empty Bucket";
																																																																																							this.useStyle = 1;
																																																																																							this.useTurn = true;
																																																																																							this.useAnimation = 15;
																																																																																							this.useTime = 10;
																																																																																							this.width = 20;
																																																																																							this.height = 20;
																																																																																							this.headSlot = 13;
																																																																																							this.defense = 1;
																																																																																						}
																																																																																						else
																																																																																						{
																																																																																							if (this.type == 206)
																																																																																							{
																																																																																								this.name = "Water Bucket";
																																																																																								this.useStyle = 1;
																																																																																								this.useTurn = true;
																																																																																								this.useAnimation = 15;
																																																																																								this.useTime = 10;
																																																																																								this.width = 20;
																																																																																								this.height = 20;
																																																																																							}
																																																																																							else
																																																																																							{
																																																																																								if (this.type == 207)
																																																																																								{
																																																																																									this.name = "Lava Bucket";
																																																																																									this.useStyle = 1;
																																																																																									this.useTurn = true;
																																																																																									this.useAnimation = 15;
																																																																																									this.useTime = 10;
																																																																																									this.width = 20;
																																																																																									this.height = 20;
																																																																																								}
																																																																																								else
																																																																																								{
																																																																																									if (this.type == 208)
																																																																																									{
																																																																																										this.name = "Jungle Rose";
																																																																																										this.width = 20;
																																																																																										this.height = 20;
																																																																																										this.value = 100;
																																																																																										this.headSlot = 23;
																																																																																										this.toolTip = "'It's pretty, oh so pretty'";
																																																																																										this.vanity = true;
																																																																																									}
																																																																																									else
																																																																																									{
																																																																																										if (this.type == 209)
																																																																																										{
																																																																																											this.name = "Stinger";
																																																																																											this.width = 16;
																																																																																											this.height = 18;
																																																																																											this.maxStack = 99;
																																																																																											this.value = 200;
																																																																																										}
																																																																																										else
																																																																																										{
																																																																																											if (this.type == 210)
																																																																																											{
																																																																																												this.name = "Vine";
																																																																																												this.width = 14;
																																																																																												this.height = 20;
																																																																																												this.maxStack = 99;
																																																																																												this.value = 1000;
																																																																																											}
																																																																																											else
																																																																																											{
																																																																																												if (this.type == 211)
																																																																																												{
																																																																																													this.name = "Feral Claws";
																																																																																													this.width = 20;
																																																																																													this.height = 20;
																																																																																													this.accessory = true;
																																																																																													this.rare = 3;
																																																																																													this.toolTip = "12% increased melee speed";
																																																																																													this.value = 50000;
																																																																																												}
																																																																																												else
																																																																																												{
																																																																																													if (this.type == 212)
																																																																																													{
																																																																																														this.name = "Anklet of the Wind";
																																																																																														this.width = 20;
																																																																																														this.height = 20;
																																																																																														this.accessory = true;
																																																																																														this.rare = 3;
																																																																																														this.toolTip = "10% increased movement speed";
																																																																																														this.value = 50000;
																																																																																													}
																																																																																													else
																																																																																													{
																																																																																														if (this.type == 213)
																																																																																														{
																																																																																															this.name = "Staff of Regrowth";
																																																																																															this.useStyle = 1;
																																																																																															this.useTurn = true;
																																																																																															this.useAnimation = 25;
																																																																																															this.useTime = 13;
																																																																																															this.autoReuse = true;
																																																																																															this.width = 24;
																																																																																															this.height = 28;
																																																																																															this.damage = 7;
																																																																																															this.createTile = 2;
																																																																																															this.scale = 1.2f;
																																																																																															this.useSound = 1;
																																																																																															this.knockBack = 3f;
																																																																																															this.rare = 3;
																																																																																															this.value = 2000;
																																																																																															this.toolTip = "Creates grass on dirt";
																																																																																															this.melee = true;
																																																																																														}
																																																																																														else
																																																																																														{
																																																																																															if (this.type == 214)
																																																																																															{
																																																																																																this.name = "Hellstone Brick";
																																																																																																this.useStyle = 1;
																																																																																																this.useTurn = true;
																																																																																																this.useAnimation = 15;
																																																																																																this.useTime = 10;
																																																																																																this.autoReuse = true;
																																																																																																this.maxStack = 250;
																																																																																																this.consumable = true;
																																																																																																this.createTile = 76;
																																																																																																this.width = 12;
																																																																																																this.height = 12;
																																																																																															}
																																																																																															else
																																																																																															{
																																																																																																if (this.type == 215)
																																																																																																{
																																																																																																	this.name = "Whoopie Cushion";
																																																																																																	this.width = 18;
																																																																																																	this.height = 18;
																																																																																																	this.useTurn = true;
																																																																																																	this.useTime = 30;
																																																																																																	this.useAnimation = 30;
																																																																																																	this.noUseGraphic = true;
																																																																																																	this.useStyle = 10;
																																																																																																	this.useSound = 16;
																																																																																																	this.rare = 2;
																																																																																																	this.toolTip = "'May annoy others'";
																																																																																																	this.value = 100;
																																																																																																}
																																																																																																else
																																																																																																{
																																																																																																	if (this.type == 216)
																																																																																																	{
																																																																																																		this.name = "Shackle";
																																																																																																		this.width = 20;
																																																																																																		this.height = 20;
																																																																																																		this.rare = 1;
																																																																																																		this.value = 1500;
																																																																																																		this.accessory = true;
																																																																																																		this.defense = 1;
																																																																																																	}
																																																																																																	else
																																																																																																	{
																																																																																																		if (this.type == 217)
																																																																																																		{
																																																																																																			this.name = "Molten Hamaxe";
																																																																																																			this.useTurn = true;
																																																																																																			this.autoReuse = true;
																																																																																																			this.useStyle = 1;
																																																																																																			this.useAnimation = 27;
																																																																																																			this.useTime = 14;
																																																																																																			this.hammer = 70;
																																																																																																			this.axe = 30;
																																																																																																			this.width = 24;
																																																																																																			this.height = 28;
																																																																																																			this.damage = 20;
																																																																																																			this.knockBack = 7f;
																																																																																																			this.scale = 1.4f;
																																																																																																			this.useSound = 1;
																																																																																																			this.rare = 3;
																																																																																																			this.value = 15000;
																																																																																																			this.melee = true;
																																																																																																		}
																																																																																																		else
																																																																																																		{
																																																																																																			if (this.type == 218)
																																																																																																			{
																																																																																																				this.mana = 16;
																																																																																																				this.channel = true;
																																																																																																				this.damage = 34;
																																																																																																				this.useStyle = 1;
																																																																																																				this.name = "Flamelash";
																																																																																																				this.shootSpeed = 6f;
																																																																																																				this.shoot = 34;
																																																																																																				this.width = 26;
																																																																																																				this.height = 28;
																																																																																																				this.useSound = 20;
																																																																																																				this.useAnimation = 20;
																																																																																																				this.useTime = 20;
																																																																																																				this.rare = 3;
																																																																																																				this.noMelee = true;
																																																																																																				this.knockBack = 6.5f;
																																																																																																				this.toolTip = "Summons a controllable ball of fire";
																																																																																																				this.value = 10000;
																																																																																																				this.magic = true;
																																																																																																			}
																																																																																																			else
																																																																																																			{
																																																																																																				if (this.type == 219)
																																																																																																				{
																																																																																																					this.autoReuse = false;
																																																																																																					this.useStyle = 5;
																																																																																																					this.useAnimation = 11;
																																																																																																					this.useTime = 11;
																																																																																																					this.name = "Phoenix Blaster";
																																																																																																					this.width = 24;
																																																																																																					this.height = 22;
																																																																																																					this.shoot = 14;
																																																																																																					this.knockBack = 4f;
																																																																																																					this.useAmmo = 14;
																																																																																																					this.useSound = 11;
																																																																																																					this.damage = 23;
																																																																																																					this.shootSpeed = 13f;
																																																																																																					this.noMelee = true;
																																																																																																					this.value = 50000;
																																																																																																					this.scale = 0.75f;
																																																																																																					this.rare = 3;
																																																																																																					this.ranged = true;
																																																																																																				}
																																																																																																				else
																																																																																																				{
																																																																																																					if (this.type == 220)
																																																																																																					{
																																																																																																						this.name = "Sunfury";
																																																																																																						this.noMelee = true;
																																																																																																						this.useStyle = 5;
																																																																																																						this.useAnimation = 45;
																																																																																																						this.useTime = 45;
																																																																																																						this.knockBack = 7f;
																																																																																																						this.width = 30;
																																																																																																						this.height = 10;
																																																																																																						this.damage = 33;
																																																																																																						this.scale = 1.1f;
																																																																																																						this.noUseGraphic = true;
																																																																																																						this.shoot = 35;
																																																																																																						this.shootSpeed = 12f;
																																																																																																						this.useSound = 1;
																																																																																																						this.rare = 3;
																																																																																																						this.value = 27000;
																																																																																																						this.melee = true;
																																																																																																						this.channel = true;
																																																																																																					}
																																																																																																					else
																																																																																																					{
																																																																																																						if (this.type == 221)
																																																																																																						{
																																																																																																							this.name = "Hellforge";
																																																																																																							this.useStyle = 1;
																																																																																																							this.useTurn = true;
																																																																																																							this.useAnimation = 15;
																																																																																																							this.useTime = 10;
																																																																																																							this.autoReuse = true;
																																																																																																							this.maxStack = 99;
																																																																																																							this.consumable = true;
																																																																																																							this.createTile = 77;
																																																																																																							this.width = 26;
																																																																																																							this.height = 24;
																																																																																																							this.value = 3000;
																																																																																																						}
																																																																																																						else
																																																																																																						{
																																																																																																							if (this.type == 222)
																																																																																																							{
																																																																																																								this.name = "Clay Pot";
																																																																																																								this.useStyle = 1;
																																																																																																								this.useTurn = true;
																																																																																																								this.useAnimation = 15;
																																																																																																								this.useTime = 10;
																																																																																																								this.autoReuse = true;
																																																																																																								this.maxStack = 99;
																																																																																																								this.consumable = true;
																																																																																																								this.createTile = 78;
																																																																																																								this.width = 14;
																																																																																																								this.height = 14;
																																																																																																								this.value = 100;
																																																																																																								this.toolTip = "Grows plants";
																																																																																																							}
																																																																																																							else
																																																																																																							{
																																																																																																								if (this.type == 223)
																																																																																																								{
																																																																																																									this.name = "Nature's Gift";
																																																																																																									this.width = 20;
																																																																																																									this.height = 22;
																																																																																																									this.rare = 3;
																																																																																																									this.value = 27000;
																																																																																																									this.accessory = true;
																																																																																																									this.toolTip = "6% reduced mana usage";
																																																																																																								}
																																																																																																								else
																																																																																																								{
																																																																																																									if (this.type == 224)
																																																																																																									{
																																																																																																										this.name = "Bed";
																																																																																																										this.useStyle = 1;
																																																																																																										this.useTurn = true;
																																																																																																										this.useAnimation = 15;
																																																																																																										this.useTime = 10;
																																																																																																										this.maxStack = 99;
																																																																																																										this.consumable = true;
																																																																																																										this.createTile = 79;
																																																																																																										this.width = 28;
																																																																																																										this.height = 20;
																																																																																																										this.value = 2000;
																																																																																																									}
																																																																																																									else
																																																																																																									{
																																																																																																										if (this.type == 225)
																																																																																																										{
																																																																																																											this.name = "Silk";
																																																																																																											this.maxStack = 99;
																																																																																																											this.width = 22;
																																																																																																											this.height = 22;
																																																																																																											this.value = 1000;
																																																																																																										}
																																																																																																										else
																																																																																																										{
																																																																																																											if (this.type == 226)
																																																																																																											{
																																																																																																												this.name = "Lesser Restoration Potion";
																																																																																																												this.useSound = 3;
																																																																																																												this.healMana = 50;
																																																																																																												this.healLife = 50;
																																																																																																												this.useStyle = 2;
																																																																																																												this.useTurn = true;
																																																																																																												this.useAnimation = 17;
																																																																																																												this.useTime = 17;
																																																																																																												this.maxStack = 20;
																																																																																																												this.consumable = true;
																																																																																																												this.width = 14;
																																																																																																												this.height = 24;
																																																																																																												this.potion = true;
																																																																																																												this.value = 2000;
																																																																																																											}
																																																																																																											else
																																																																																																											{
																																																																																																												if (this.type == 227)
																																																																																																												{
																																																																																																													this.name = "Restoration Potion";
																																																																																																													this.useSound = 3;
																																																																																																													this.healMana = 100;
																																																																																																													this.healLife = 100;
																																																																																																													this.useStyle = 2;
																																																																																																													this.useTurn = true;
																																																																																																													this.useAnimation = 17;
																																																																																																													this.useTime = 17;
																																																																																																													this.maxStack = 20;
																																																																																																													this.consumable = true;
																																																																																																													this.width = 14;
																																																																																																													this.height = 24;
																																																																																																													this.potion = true;
																																																																																																													this.value = 4000;
																																																																																																												}
																																																																																																												else
																																																																																																												{
																																																																																																													if (this.type == 228)
																																																																																																													{
																																																																																																														this.name = "Jungle Hat";
																																																																																																														this.width = 18;
																																																																																																														this.height = 18;
																																																																																																														this.defense = 4;
																																																																																																														this.headSlot = 8;
																																																																																																														this.rare = 3;
																																																																																																														this.value = 45000;
																																																																																																														this.toolTip = "Increases maximum mana by 20";
																																																																																																														this.toolTip2 = "3% increased magic critical strike chance";
																																																																																																													}
																																																																																																													else
																																																																																																													{
																																																																																																														if (this.type == 229)
																																																																																																														{
																																																																																																															this.name = "Jungle Shirt";
																																																																																																															this.width = 18;
																																																																																																															this.height = 18;
																																																																																																															this.defense = 5;
																																																																																																															this.bodySlot = 8;
																																																																																																															this.rare = 3;
																																																																																																															this.value = 30000;
																																																																																																															this.toolTip = "Increases maximum mana by 20";
																																																																																																															this.toolTip2 = "3% increased magic critical strike chance";
																																																																																																														}
																																																																																																														else
																																																																																																														{
																																																																																																															if (this.type == 230)
																																																																																																															{
																																																																																																																this.name = "Jungle Pants";
																																																																																																																this.width = 18;
																																																																																																																this.height = 18;
																																																																																																																this.defense = 4;
																																																																																																																this.legSlot = 8;
																																																																																																																this.rare = 3;
																																																																																																																this.value = 30000;
																																																																																																																this.toolTip = "Increases maximum mana by 20";
																																																																																																																this.toolTip2 = "3% increased magic critical strike chance";
																																																																																																															}
																																																																																																															else
																																																																																																															{
																																																																																																																if (this.type == 231)
																																																																																																																{
																																																																																																																	this.name = "Molten Helmet";
																																																																																																																	this.width = 18;
																																																																																																																	this.height = 18;
																																																																																																																	this.defense = 8;
																																																																																																																	this.headSlot = 9;
																																																																																																																	this.rare = 3;
																																																																																																																	this.value = 45000;
																																																																																																																}
																																																																																																																else
																																																																																																																{
																																																																																																																	if (this.type == 232)
																																																																																																																	{
																																																																																																																		this.name = "Molten Breastplate";
																																																																																																																		this.width = 18;
																																																																																																																		this.height = 18;
																																																																																																																		this.defense = 9;
																																																																																																																		this.bodySlot = 9;
																																																																																																																		this.rare = 3;
																																																																																																																		this.value = 30000;
																																																																																																																	}
																																																																																																																	else
																																																																																																																	{
																																																																																																																		if (this.type == 233)
																																																																																																																		{
																																																																																																																			this.name = "Molten Greaves";
																																																																																																																			this.width = 18;
																																																																																																																			this.height = 18;
																																																																																																																			this.defense = 8;
																																																																																																																			this.legSlot = 9;
																																																																																																																			this.rare = 3;
																																																																																																																			this.value = 30000;
																																																																																																																		}
																																																																																																																		else
																																																																																																																		{
																																																																																																																			if (this.type == 234)
																																																																																																																			{
																																																																																																																				this.name = "Meteor Shot";
																																																																																																																				this.shootSpeed = 3f;
																																																																																																																				this.shoot = 36;
																																																																																																																				this.damage = 9;
																																																																																																																				this.width = 8;
																																																																																																																				this.height = 8;
																																																																																																																				this.maxStack = 250;
																																																																																																																				this.consumable = true;
																																																																																																																				this.ammo = 14;
																																																																																																																				this.knockBack = 1f;
																																																																																																																				this.value = 8;
																																																																																																																				this.rare = 1;
																																																																																																																				this.ranged = true;
																																																																																																																			}
																																																																																																																			else
																																																																																																																			{
																																																																																																																				if (this.type == 235)
																																																																																																																				{
																																																																																																																					this.useStyle = 1;
																																																																																																																					this.name = "Sticky Bomb";
																																																																																																																					this.shootSpeed = 5f;
																																																																																																																					this.shoot = 37;
																																																																																																																					this.width = 20;
																																																																																																																					this.height = 20;
																																																																																																																					this.maxStack = 20;
																																																																																																																					this.consumable = true;
																																																																																																																					this.useSound = 1;
																																																																																																																					this.useAnimation = 25;
																																																																																																																					this.useTime = 25;
																																																																																																																					this.noUseGraphic = true;
																																																																																																																					this.noMelee = true;
																																																																																																																					this.value = 500;
																																																																																																																					this.damage = 0;
																																																																																																																					this.toolTip = "'Tossing may be difficult.'";
																																																																																																																				}
																																																																																																																				else
																																																																																																																				{
																																																																																																																					if (this.type == 236)
																																																																																																																					{
																																																																																																																						this.name = "Black Lens";
																																																																																																																						this.width = 12;
																																																																																																																						this.height = 20;
																																																																																																																						this.maxStack = 99;
																																																																																																																						this.value = 5000;
																																																																																																																					}
																																																																																																																					else
																																																																																																																					{
																																																																																																																						if (this.type == 237)
																																																																																																																						{
																																																																																																																							this.name = "Sunglasses";
																																																																																																																							this.width = 28;
																																																																																																																							this.height = 12;
																																																																																																																							this.headSlot = 12;
																																																																																																																							this.rare = 2;
																																																																																																																							this.value = 10000;
																																																																																																																							this.toolTip = "'Makes you look cool!'";
																																																																																																																							this.vanity = true;
																																																																																																																						}
																																																																																																																						else
																																																																																																																						{
																																																																																																																							if (this.type == 238)
																																																																																																																							{
																																																																																																																								this.name = "Wizard Hat";
																																																																																																																								this.width = 28;
																																																																																																																								this.height = 20;
																																																																																																																								this.headSlot = 14;
																																																																																																																								this.rare = 2;
																																																																																																																								this.value = 10000;
																																																																																																																								this.defense = 2;
																																																																																																																								this.toolTip = "15% increased magic damage";
																																																																																																																							}
																																																																																																																							else
																																																																																																																							{
																																																																																																																								if (this.type == 239)
																																																																																																																								{
																																																																																																																									this.name = "Top Hat";
																																																																																																																									this.width = 18;
																																																																																																																									this.height = 18;
																																																																																																																									this.headSlot = 15;
																																																																																																																									this.value = 10000;
																																																																																																																									this.vanity = true;
																																																																																																																								}
																																																																																																																								else
																																																																																																																								{
																																																																																																																									if (this.type == 240)
																																																																																																																									{
																																																																																																																										this.name = "Tuxedo Shirt";
																																																																																																																										this.width = 18;
																																																																																																																										this.height = 18;
																																																																																																																										this.bodySlot = 10;
																																																																																																																										this.value = 5000;
																																																																																																																										this.vanity = true;
																																																																																																																									}
																																																																																																																									else
																																																																																																																									{
																																																																																																																										if (this.type == 241)
																																																																																																																										{
																																																																																																																											this.name = "Tuxedo Pants";
																																																																																																																											this.width = 18;
																																																																																																																											this.height = 18;
																																																																																																																											this.legSlot = 10;
																																																																																																																											this.value = 5000;
																																																																																																																											this.vanity = true;
																																																																																																																										}
																																																																																																																										else
																																																																																																																										{
																																																																																																																											if (this.type == 242)
																																																																																																																											{
																																																																																																																												this.name = "Summer Hat";
																																																																																																																												this.width = 18;
																																																																																																																												this.height = 18;
																																																																																																																												this.headSlot = 16;
																																																																																																																												this.value = 10000;
																																																																																																																												this.vanity = true;
																																																																																																																											}
																																																																																																																											else
																																																																																																																											{
																																																																																																																												if (this.type == 243)
																																																																																																																												{
																																																																																																																													this.name = "Bunny Hood";
																																																																																																																													this.width = 18;
																																																																																																																													this.height = 18;
																																																																																																																													this.headSlot = 17;
																																																																																																																													this.value = 20000;
																																																																																																																													this.vanity = true;
																																																																																																																												}
																																																																																																																												else
																																																																																																																												{
																																																																																																																													if (this.type == 244)
																																																																																																																													{
																																																																																																																														this.name = "Plumber's Hat";
																																																																																																																														this.width = 18;
																																																																																																																														this.height = 18;
																																																																																																																														this.headSlot = 18;
																																																																																																																														this.value = 10000;
																																																																																																																														this.vanity = true;
																																																																																																																													}
																																																																																																																													else
																																																																																																																													{
																																																																																																																														if (this.type == 245)
																																																																																																																														{
																																																																																																																															this.name = "Plumber's Shirt";
																																																																																																																															this.width = 18;
																																																																																																																															this.height = 18;
																																																																																																																															this.bodySlot = 11;
																																																																																																																															this.value = 250000;
																																																																																																																															this.vanity = true;
																																																																																																																														}
																																																																																																																														else
																																																																																																																														{
																																																																																																																															if (this.type == 246)
																																																																																																																															{
																																																																																																																																this.name = "Plumber's Pants";
																																																																																																																																this.width = 18;
																																																																																																																																this.height = 18;
																																																																																																																																this.legSlot = 11;
																																																																																																																																this.value = 250000;
																																																																																																																																this.vanity = true;
																																																																																																																															}
																																																																																																																															else
																																																																																																																															{
																																																																																																																																if (this.type == 247)
																																																																																																																																{
																																																																																																																																	this.name = "Hero's Hat";
																																																																																																																																	this.width = 18;
																																																																																																																																	this.height = 12;
																																																																																																																																	this.headSlot = 19;
																																																																																																																																	this.value = 10000;
																																																																																																																																	this.vanity = true;
																																																																																																																																}
																																																																																																																																else
																																																																																																																																{
																																																																																																																																	if (this.type == 248)
																																																																																																																																	{
																																																																																																																																		this.name = "Hero's Shirt";
																																																																																																																																		this.width = 18;
																																																																																																																																		this.height = 18;
																																																																																																																																		this.bodySlot = 12;
																																																																																																																																		this.value = 5000;
																																																																																																																																		this.vanity = true;
																																																																																																																																	}
																																																																																																																																	else
																																																																																																																																	{
																																																																																																																																		if (this.type == 249)
																																																																																																																																		{
																																																																																																																																			this.name = "Hero's Pants";
																																																																																																																																			this.width = 18;
																																																																																																																																			this.height = 18;
																																																																																																																																			this.legSlot = 12;
																																																																																																																																			this.value = 5000;
																																																																																																																																			this.vanity = true;
																																																																																																																																		}
																																																																																																																																		else
																																																																																																																																		{
																																																																																																																																			if (this.type == 250)
																																																																																																																																			{
																																																																																																																																				this.name = "Fish Bowl";
																																																																																																																																				this.width = 18;
																																																																																																																																				this.height = 18;
																																																																																																																																				this.headSlot = 20;
																																																																																																																																				this.value = 10000;
																																																																																																																																				this.vanity = true;
																																																																																																																																			}
																																																																																																																																			else
																																																																																																																																			{
																																																																																																																																				if (this.type == 251)
																																																																																																																																				{
																																																																																																																																					this.name = "Archaeologist's Hat";
																																																																																																																																					this.width = 18;
																																																																																																																																					this.height = 12;
																																																																																																																																					this.headSlot = 21;
																																																																																																																																					this.value = 10000;
																																																																																																																																					this.vanity = true;
																																																																																																																																				}
																																																																																																																																				else
																																																																																																																																				{
																																																																																																																																					if (this.type == 252)
																																																																																																																																					{
																																																																																																																																						this.name = "Archaeologist's Jacket";
																																																																																																																																						this.width = 18;
																																																																																																																																						this.height = 18;
																																																																																																																																						this.bodySlot = 13;
																																																																																																																																						this.value = 5000;
																																																																																																																																						this.vanity = true;
																																																																																																																																					}
																																																																																																																																					else
																																																																																																																																					{
																																																																																																																																						if (this.type == 253)
																																																																																																																																						{
																																																																																																																																							this.name = "Archaeologist's Pants";
																																																																																																																																							this.width = 18;
																																																																																																																																							this.height = 18;
																																																																																																																																							this.legSlot = 13;
																																																																																																																																							this.value = 5000;
																																																																																																																																							this.vanity = true;
																																																																																																																																						}
																																																																																																																																						else
																																																																																																																																						{
																																																																																																																																							if (this.type == 254)
																																																																																																																																							{
																																																																																																																																								this.name = "Black Dye";
																																																																																																																																								this.maxStack = 99;
																																																																																																																																								this.width = 12;
																																																																																																																																								this.height = 20;
																																																																																																																																								this.value = 10000;
																																																																																																																																							}
																																																																																																																																							else
																																																																																																																																							{
																																																																																																																																								if (this.type == 255)
																																																																																																																																								{
																																																																																																																																									this.name = "Green Dye";
																																																																																																																																									this.maxStack = 99;
																																																																																																																																									this.width = 12;
																																																																																																																																									this.height = 20;
																																																																																																																																									this.value = 2000;
																																																																																																																																								}
																																																																																																																																								else
																																																																																																																																								{
																																																																																																																																									if (this.type == 256)
																																																																																																																																									{
																																																																																																																																										this.name = "Ninja Hood";
																																																																																																																																										this.width = 18;
																																																																																																																																										this.height = 12;
																																																																																																																																										this.headSlot = 22;
																																																																																																																																										this.value = 10000;
																																																																																																																																										this.vanity = true;
																																																																																																																																									}
																																																																																																																																									else
																																																																																																																																									{
																																																																																																																																										if (this.type == 257)
																																																																																																																																										{
																																																																																																																																											this.name = "Ninja Shirt";
																																																																																																																																											this.width = 18;
																																																																																																																																											this.height = 18;
																																																																																																																																											this.bodySlot = 14;
																																																																																																																																											this.value = 5000;
																																																																																																																																											this.vanity = true;
																																																																																																																																										}
																																																																																																																																										else
																																																																																																																																										{
																																																																																																																																											if (this.type == 258)
																																																																																																																																											{
																																																																																																																																												this.name = "Ninja Pants";
																																																																																																																																												this.width = 18;
																																																																																																																																												this.height = 18;
																																																																																																																																												this.legSlot = 14;
																																																																																																																																												this.value = 5000;
																																																																																																																																												this.vanity = true;
																																																																																																																																											}
																																																																																																																																											else
																																																																																																																																											{
																																																																																																																																												if (this.type == 259)
																																																																																																																																												{
																																																																																																																																													this.name = "Leather";
																																																																																																																																													this.width = 18;
																																																																																																																																													this.height = 20;
																																																																																																																																													this.maxStack = 99;
																																																																																																																																													this.value = 50;
																																																																																																																																												}
																																																																																																																																												else
																																																																																																																																												{
																																																																																																																																													if (this.type == 260)
																																																																																																																																													{
																																																																																																																																														this.name = "Red Hat";
																																																																																																																																														this.width = 18;
																																																																																																																																														this.height = 14;
																																																																																																																																														this.headSlot = 24;
																																																																																																																																														this.value = 1000;
																																																																																																																																														this.vanity = true;
																																																																																																																																													}
																																																																																																																																													else
																																																																																																																																													{
																																																																																																																																														if (this.type == 261)
																																																																																																																																														{
																																																																																																																																															this.name = "Goldfish";
																																																																																																																																															this.useStyle = 2;
																																																																																																																																															this.useSound = 2;
																																																																																																																																															this.useTurn = false;
																																																																																																																																															this.useAnimation = 17;
																																																																																																																																															this.useTime = 17;
																																																																																																																																															this.width = 20;
																																																																																																																																															this.height = 10;
																																																																																																																																															this.maxStack = 99;
																																																																																																																																															this.healLife = 20;
																																																																																																																																															this.consumable = true;
																																																																																																																																															this.value = 1000;
																																																																																																																																															this.potion = true;
																																																																																																																																															this.toolTip = "'It's smiling, might be a good snack'";
																																																																																																																																														}
																																																																																																																																														else
																																																																																																																																														{
																																																																																																																																															if (this.type == 262)
																																																																																																																																															{
																																																																																																																																																this.name = "Robe";
																																																																																																																																																this.width = 18;
																																																																																																																																																this.height = 14;
																																																																																																																																																this.bodySlot = 15;
																																																																																																																																																this.value = 2000;
																																																																																																																																																this.vanity = true;
																																																																																																																																															}
																																																																																																																																															else
																																																																																																																																															{
																																																																																																																																																if (this.type == 263)
																																																																																																																																																{
																																																																																																																																																	this.name = "Robot Hat";
																																																																																																																																																	this.width = 18;
																																																																																																																																																	this.height = 18;
																																																																																																																																																	this.headSlot = 25;
																																																																																																																																																	this.value = 10000;
																																																																																																																																																	this.vanity = true;
																																																																																																																																																}
																																																																																																																																																else
																																																																																																																																																{
																																																																																																																																																	if (this.type == 264)
																																																																																																																																																	{
																																																																																																																																																		this.name = "Gold Crown";
																																																																																																																																																		this.width = 18;
																																																																																																																																																		this.height = 18;
																																																																																																																																																		this.headSlot = 26;
																																																																																																																																																		this.value = 10000;
																																																																																																																																																		this.vanity = true;
																																																																																																																																																	}
																																																																																																																																																	else
																																																																																																																																																	{
																																																																																																																																																		if (this.type == 265)
																																																																																																																																																		{
																																																																																																																																																			this.name = "Hellfire Arrow";
																																																																																																																																																			this.shootSpeed = 6.5f;
																																																																																																																																																			this.shoot = 41;
																																																																																																																																																			this.damage = 10;
																																																																																																																																																			this.width = 10;
																																																																																																																																																			this.height = 28;
																																																																																																																																																			this.maxStack = 250;
																																																																																																																																																			this.consumable = true;
																																																																																																																																																			this.ammo = 1;
																																																																																																																																																			this.knockBack = 8f;
																																																																																																																																																			this.value = 100;
																																																																																																																																																			this.rare = 2;
																																																																																																																																																			this.ranged = true;
																																																																																																																																																		}
																																																																																																																																																		else
																																																																																																																																																		{
																																																																																																																																																			if (this.type == 266)
																																																																																																																																																			{
																																																																																																																																																				this.useStyle = 5;
																																																																																																																																																				this.useAnimation = 20;
																																																																																																																																																				this.useTime = 20;
																																																																																																																																																				this.name = "Sandgun";
																																																																																																																																																				this.width = 40;
																																																																																																																																																				this.height = 20;
																																																																																																																																																				this.shoot = 42;
																																																																																																																																																				this.useAmmo = 42;
																																																																																																																																																				this.useSound = 11;
																																																																																																																																																				this.damage = 10;
																																																																																																																																																				this.shootSpeed = 14f;
																																																																																																																																																				this.noMelee = true;
																																																																																																																																																				this.knockBack = 5f;
																																																																																																																																																				this.value = 10000;
																																																																																																																																																				this.rare = 2;
																																																																																																																																																				this.toolTip = "'This is a good idea!'";
																																																																																																																																																				this.ranged = true;
																																																																																																																																																			}
																																																																																																																																																			else
																																																																																																																																																			{
																																																																																																																																																				if (this.type == 267)
																																																																																																																																																				{
																																																																																																																																																					this.accessory = true;
																																																																																																																																																					this.name = "Guide Voodoo Doll";
																																																																																																																																																					this.width = 14;
																																																																																																																																																					this.height = 26;
																																																																																																																																																					this.value = 1000;
																																																																																																																																																					this.toolTip = "'You are a terrible person.'";
																																																																																																																																																				}
																																																																																																																																																				else
																																																																																																																																																				{
																																																																																																																																																					if (this.type == 268)
																																																																																																																																																					{
																																																																																																																																																						this.headSlot = 27;
																																																																																																																																																						this.defense = 2;
																																																																																																																																																						this.name = "Diving Helmet";
																																																																																																																																																						this.width = 20;
																																																																																																																																																						this.height = 20;
																																																																																																																																																						this.value = 1000;
																																																																																																																																																						this.rare = 2;
																																																																																																																																																						this.toolTip = "Greatly extends underwater breathing";
																																																																																																																																																					}
																																																																																																																																																					else
																																																																																																																																																					{
																																																																																																																																																						if (this.type == 269)
																																																																																																																																																						{
																																																																																																																																																							this.name = "Familiar Shirt";
																																																																																																																																																							this.bodySlot = 0;
																																																																																																																																																							this.width = 20;
																																																																																																																																																							this.height = 20;
																																																																																																																																																							this.value = 10000;
																																																																																																																																																							this.color = Main.player[Main.myPlayer].shirtColor;
																																																																																																																																																						}
																																																																																																																																																						else
																																																																																																																																																						{
																																																																																																																																																							if (this.type == 270)
																																																																																																																																																							{
																																																																																																																																																								this.name = "Familiar Pants";
																																																																																																																																																								this.legSlot = 0;
																																																																																																																																																								this.width = 20;
																																																																																																																																																								this.height = 20;
																																																																																																																																																								this.value = 10000;
																																																																																																																																																								this.color = Main.player[Main.myPlayer].pantsColor;
																																																																																																																																																							}
																																																																																																																																																							else
																																																																																																																																																							{
																																																																																																																																																								if (this.type == 271)
																																																																																																																																																								{
																																																																																																																																																									this.name = "Familiar Wig";
																																																																																																																																																									this.headSlot = 0;
																																																																																																																																																									this.width = 20;
																																																																																																																																																									this.height = 20;
																																																																																																																																																									this.value = 10000;
																																																																																																																																																									this.color = Main.player[Main.myPlayer].hairColor;
																																																																																																																																																								}
																																																																																																																																																								else
																																																																																																																																																								{
																																																																																																																																																									if (this.type == 272)
																																																																																																																																																									{
																																																																																																																																																										this.mana = 18;
																																																																																																																																																										this.damage = 35;
																																																																																																																																																										this.useStyle = 5;
																																																																																																																																																										this.name = "Demon Scythe";
																																																																																																																																																										this.shootSpeed = 0.2f;
																																																																																																																																																										this.shoot = 45;
																																																																																																																																																										this.width = 26;
																																																																																																																																																										this.height = 28;
																																																																																																																																																										this.useSound = 8;
																																																																																																																																																										this.useAnimation = 20;
																																																																																																																																																										this.useTime = 20;
																																																																																																																																																										this.rare = 3;
																																																																																																																																																										this.noMelee = true;
																																																																																																																																																										this.knockBack = 5f;
																																																																																																																																																										this.scale = 0.9f;
																																																																																																																																																										this.toolTip = "Casts a demon scythe";
																																																																																																																																																										this.value = 10000;
																																																																																																																																																										this.magic = true;
																																																																																																																																																									}
																																																																																																																																																									else
																																																																																																																																																									{
																																																																																																																																																										if (this.type == 273)
																																																																																																																																																										{
																																																																																																																																																											this.name = "Night's Edge";
																																																																																																																																																											this.useStyle = 1;
																																																																																																																																																											this.useAnimation = 27;
																																																																																																																																																											this.useTime = 27;
																																																																																																																																																											this.knockBack = 4.5f;
																																																																																																																																																											this.width = 40;
																																																																																																																																																											this.height = 40;
																																																																																																																																																											this.damage = 42;
																																																																																																																																																											this.scale = 1.15f;
																																																																																																																																																											this.useSound = 1;
																																																																																																																																																											this.rare = 3;
																																																																																																																																																											this.value = 27000;
																																																																																																																																																											this.melee = true;
																																																																																																																																																										}
																																																																																																																																																										else
																																																																																																																																																										{
																																																																																																																																																											if (this.type == 274)
																																																																																																																																																											{
																																																																																																																																																												this.name = "Dark Lance";
																																																																																																																																																												this.useStyle = 5;
																																																																																																																																																												this.useAnimation = 25;
																																																																																																																																																												this.useTime = 25;
																																																																																																																																																												this.shootSpeed = 5f;
																																																																																																																																																												this.knockBack = 4f;
																																																																																																																																																												this.width = 40;
																																																																																																																																																												this.height = 40;
																																																																																																																																																												this.damage = 27;
																																																																																																																																																												this.scale = 1.1f;
																																																																																																																																																												this.useSound = 1;
																																																																																																																																																												this.shoot = 46;
																																																																																																																																																												this.rare = 3;
																																																																																																																																																												this.value = 27000;
																																																																																																																																																												this.noMelee = true;
																																																																																																																																																												this.noUseGraphic = true;
																																																																																																																																																												this.melee = true;
																																																																																																																																																											}
																																																																																																																																																											else
																																																																																																																																																											{
																																																																																																																																																												if (this.type == 275)
																																																																																																																																																												{
																																																																																																																																																													this.name = "Coral";
																																																																																																																																																													this.useStyle = 1;
																																																																																																																																																													this.useTurn = true;
																																																																																																																																																													this.useAnimation = 15;
																																																																																																																																																													this.useTime = 10;
																																																																																																																																																													this.autoReuse = true;
																																																																																																																																																													this.maxStack = 250;
																																																																																																																																																													this.consumable = true;
																																																																																																																																																													this.createTile = 81;
																																																																																																																																																													this.width = 20;
																																																																																																																																																													this.height = 22;
																																																																																																																																																													this.value = 400;
																																																																																																																																																												}
																																																																																																																																																												else
																																																																																																																																																												{
																																																																																																																																																													if (this.type == 276)
																																																																																																																																																													{
																																																																																																																																																														this.name = "Cactus";
																																																																																																																																																														this.maxStack = 250;
																																																																																																																																																														this.width = 12;
																																																																																																																																																														this.height = 12;
																																																																																																																																																														this.value = 10;
																																																																																																																																																													}
																																																																																																																																																													else
																																																																																																																																																													{
																																																																																																																																																														if (this.type == 277)
																																																																																																																																																														{
																																																																																																																																																															this.name = "Trident";
																																																																																																																																																															this.useStyle = 5;
																																																																																																																																																															this.useAnimation = 31;
																																																																																																																																																															this.useTime = 31;
																																																																																																																																																															this.shootSpeed = 4f;
																																																																																																																																																															this.knockBack = 5f;
																																																																																																																																																															this.width = 40;
																																																																																																																																																															this.height = 40;
																																																																																																																																																															this.damage = 10;
																																																																																																																																																															this.scale = 1.1f;
																																																																																																																																																															this.useSound = 1;
																																																																																																																																																															this.shoot = 47;
																																																																																																																																																															this.rare = 1;
																																																																																																																																																															this.value = 10000;
																																																																																																																																																															this.noMelee = true;
																																																																																																																																																															this.noUseGraphic = true;
																																																																																																																																																															this.melee = true;
																																																																																																																																																														}
																																																																																																																																																														else
																																																																																																																																																														{
																																																																																																																																																															if (this.type == 278)
																																																																																																																																																															{
																																																																																																																																																																this.name = "Silver Bullet";
																																																																																																																																																																this.shootSpeed = 4.5f;
																																																																																																																																																																this.shoot = 14;
																																																																																																																																																																this.damage = 9;
																																																																																																																																																																this.width = 8;
																																																																																																																																																																this.height = 8;
																																																																																																																																																																this.maxStack = 250;
																																																																																																																																																																this.consumable = true;
																																																																																																																																																																this.ammo = 14;
																																																																																																																																																																this.knockBack = 3f;
																																																																																																																																																																this.value = 15;
																																																																																																																																																																this.ranged = true;
																																																																																																																																																															}
																																																																																																																																																															else
																																																																																																																																																															{
																																																																																																																																																																if (this.type == 279)
																																																																																																																																																																{
																																																																																																																																																																	this.useStyle = 1;
																																																																																																																																																																	this.name = "Throwing Knife";
																																																																																																																																																																	this.shootSpeed = 10f;
																																																																																																																																																																	this.shoot = 48;
																																																																																																																																																																	this.damage = 12;
																																																																																																																																																																	this.width = 18;
																																																																																																																																																																	this.height = 20;
																																																																																																																																																																	this.maxStack = 250;
																																																																																																																																																																	this.consumable = true;
																																																																																																																																																																	this.useSound = 1;
																																																																																																																																																																	this.useAnimation = 15;
																																																																																																																																																																	this.useTime = 15;
																																																																																																																																																																	this.noUseGraphic = true;
																																																																																																																																																																	this.noMelee = true;
																																																																																																																																																																	this.value = 50;
																																																																																																																																																																	this.knockBack = 2f;
																																																																																																																																																																	this.ranged = true;
																																																																																																																																																																}
																																																																																																																																																																else
																																																																																																																																																																{
																																																																																																																																																																	if (this.type == 280)
																																																																																																																																																																	{
																																																																																																																																																																		this.name = "Spear";
																																																																																																																																																																		this.useStyle = 5;
																																																																																																																																																																		this.useAnimation = 31;
																																																																																																																																																																		this.useTime = 31;
																																																																																																																																																																		this.shootSpeed = 3.7f;
																																																																																																																																																																		this.knockBack = 6.5f;
																																																																																																																																																																		this.width = 32;
																																																																																																																																																																		this.height = 32;
																																																																																																																																																																		this.damage = 8;
																																																																																																																																																																		this.scale = 1f;
																																																																																																																																																																		this.useSound = 1;
																																																																																																																																																																		this.shoot = 49;
																																																																																																																																																																		this.value = 1000;
																																																																																																																																																																		this.noMelee = true;
																																																																																																																																																																		this.noUseGraphic = true;
																																																																																																																																																																		this.melee = true;
																																																																																																																																																																	}
																																																																																																																																																																	else
																																																																																																																																																																	{
																																																																																																																																																																		if (this.type == 281)
																																																																																																																																																																		{
																																																																																																																																																																			this.useStyle = 5;
																																																																																																																																																																			this.autoReuse = true;
																																																																																																																																																																			this.useAnimation = 45;
																																																																																																																																																																			this.useTime = 45;
																																																																																																																																																																			this.name = "Blowpipe";
																																																																																																																																																																			this.width = 38;
																																																																																																																																																																			this.height = 6;
																																																																																																																																																																			this.shoot = 10;
																																																																																																																																																																			this.useAmmo = 51;
																																																																																																																																																																			this.useSound = 5;
																																																																																																																																																																			this.damage = 9;
																																																																																																																																																																			this.shootSpeed = 11f;
																																																																																																																																																																			this.noMelee = true;
																																																																																																																																																																			this.value = 10000;
																																																																																																																																																																			this.knockBack = 4f;
																																																																																																																																																																			this.useAmmo = 51;
																																																																																																																																																																			this.toolTip = "Allows the collection of seeds for ammo";
																																																																																																																																																																		}
																																																																																																																																																																		else
																																																																																																																																																																		{
																																																																																																																																																																			if (this.type == 282)
																																																																																																																																																																			{
																																																																																																																																																																				this.useStyle = 1;
																																																																																																																																																																				this.name = "Glowstick";
																																																																																																																																																																				this.shootSpeed = 6f;
																																																																																																																																																																				this.shoot = 50;
																																																																																																																																																																				this.width = 12;
																																																																																																																																																																				this.height = 12;
																																																																																																																																																																				this.maxStack = 99;
																																																																																																																																																																				this.consumable = true;
																																																																																																																																																																				this.useSound = 1;
																																																																																																																																																																				this.useAnimation = 15;
																																																																																																																																																																				this.useTime = 15;
																																																																																																																																																																				this.noMelee = true;
																																																																																																																																																																				this.value = 10;
																																																																																																																																																																				this.holdStyle = 1;
																																																																																																																																																																				this.toolTip = "Works when wet";
																																																																																																																																																																			}
																																																																																																																																																																			else
																																																																																																																																																																			{
																																																																																																																																																																				if (this.type == 283)
																																																																																																																																																																				{
																																																																																																																																																																					this.name = "Seed";
																																																																																																																																																																					this.shoot = 51;
																																																																																																																																																																					this.width = 8;
																																																																																																																																																																					this.height = 8;
																																																																																																																																																																					this.maxStack = 250;
																																																																																																																																																																					this.ammo = 51;
																																																																																																																																																																					this.toolTip = "For use with Blowpipe";
																																																																																																																																																																				}
																																																																																																																																																																				else
																																																																																																																																																																				{
																																																																																																																																																																					if (this.type == 284)
																																																																																																																																																																					{
																																																																																																																																																																						this.noMelee = true;
																																																																																																																																																																						this.useStyle = 1;
																																																																																																																																																																						this.name = "Wooden Boomerang";
																																																																																																																																																																						this.shootSpeed = 6.5f;
																																																																																																																																																																						this.shoot = 52;
																																																																																																																																																																						this.damage = 7;
																																																																																																																																																																						this.knockBack = 5f;
																																																																																																																																																																						this.width = 14;
																																																																																																																																																																						this.height = 28;
																																																																																																																																																																						this.useSound = 1;
																																																																																																																																																																						this.useAnimation = 16;
																																																																																																																																																																						this.useTime = 16;
																																																																																																																																																																						this.noUseGraphic = true;
																																																																																																																																																																						this.value = 5000;
																																																																																																																																																																						this.ranged = true;
																																																																																																																																																																					}
																																																																																																																																																																					else
																																																																																																																																																																					{
																																																																																																																																																																						if (this.type == 285)
																																																																																																																																																																						{
																																																																																																																																																																							this.name = "Aglet";
																																																																																																																																																																							this.width = 24;
																																																																																																																																																																							this.height = 8;
																																																																																																																																																																							this.accessory = true;
																																																																																																																																																																							this.toolTip = "5% increased movement speed";
																																																																																																																																																																							this.value = 5000;
																																																																																																																																																																						}
																																																																																																																																																																						else
																																																																																																																																																																						{
																																																																																																																																																																							if (this.type == 286)
																																																																																																																																																																							{
																																																																																																																																																																								this.useStyle = 1;
																																																																																																																																																																								this.name = "Sticky Glowstick";
																																																																																																																																																																								this.shootSpeed = 6f;
																																																																																																																																																																								this.shoot = 53;
																																																																																																																																																																								this.width = 12;
																																																																																																																																																																								this.height = 12;
																																																																																																																																																																								this.maxStack = 99;
																																																																																																																																																																								this.consumable = true;
																																																																																																																																																																								this.useSound = 1;
																																																																																																																																																																								this.useAnimation = 15;
																																																																																																																																																																								this.useTime = 15;
																																																																																																																																																																								this.noMelee = true;
																																																																																																																																																																								this.value = 20;
																																																																																																																																																																								this.holdStyle = 1;
																																																																																																																																																																							}
																																																																																																																																																																							else
																																																																																																																																																																							{
																																																																																																																																																																								if (this.type == 287)
																																																																																																																																																																								{
																																																																																																																																																																									this.useStyle = 1;
																																																																																																																																																																									this.name = "Poisoned Knife";
																																																																																																																																																																									this.shootSpeed = 11f;
																																																																																																																																																																									this.shoot = 54;
																																																																																																																																																																									this.damage = 13;
																																																																																																																																																																									this.width = 18;
																																																																																																																																																																									this.height = 20;
																																																																																																																																																																									this.maxStack = 250;
																																																																																																																																																																									this.consumable = true;
																																																																																																																																																																									this.useSound = 1;
																																																																																																																																																																									this.useAnimation = 15;
																																																																																																																																																																									this.useTime = 15;
																																																																																																																																																																									this.noUseGraphic = true;
																																																																																																																																																																									this.noMelee = true;
																																																																																																																																																																									this.value = 60;
																																																																																																																																																																									this.knockBack = 2f;
																																																																																																																																																																									this.ranged = true;
																																																																																																																																																																								}
																																																																																																																																																																								else
																																																																																																																																																																								{
																																																																																																																																																																									if (this.type == 288)
																																																																																																																																																																									{
																																																																																																																																																																										this.name = "Obsidian Skin Potion";
																																																																																																																																																																										this.useSound = 3;
																																																																																																																																																																										this.useStyle = 2;
																																																																																																																																																																										this.useTurn = true;
																																																																																																																																																																										this.useAnimation = 17;
																																																																																																																																																																										this.useTime = 17;
																																																																																																																																																																										this.maxStack = 30;
																																																																																																																																																																										this.consumable = true;
																																																																																																																																																																										this.width = 14;
																																																																																																																																																																										this.height = 24;
																																																																																																																																																																										this.buffType = 1;
																																																																																																																																																																										this.buffTime = 14400;
																																																																																																																																																																										this.toolTip = "Provides immunity to lava";
																																																																																																																																																																										this.value = 1000;
																																																																																																																																																																										this.rare = 1;
																																																																																																																																																																									}
																																																																																																																																																																									else
																																																																																																																																																																									{
																																																																																																																																																																										if (this.type == 289)
																																																																																																																																																																										{
																																																																																																																																																																											this.name = "Regeneration Potion";
																																																																																																																																																																											this.useSound = 3;
																																																																																																																																																																											this.useStyle = 2;
																																																																																																																																																																											this.useTurn = true;
																																																																																																																																																																											this.useAnimation = 17;
																																																																																																																																																																											this.useTime = 17;
																																																																																																																																																																											this.maxStack = 30;
																																																																																																																																																																											this.consumable = true;
																																																																																																																																																																											this.width = 14;
																																																																																																																																																																											this.height = 24;
																																																																																																																																																																											this.buffType = 2;
																																																																																																																																																																											this.buffTime = 18000;
																																																																																																																																																																											this.toolTip = "Provides life regeneration";
																																																																																																																																																																											this.value = 1000;
																																																																																																																																																																											this.rare = 1;
																																																																																																																																																																										}
																																																																																																																																																																										else
																																																																																																																																																																										{
																																																																																																																																																																											if (this.type == 290)
																																																																																																																																																																											{
																																																																																																																																																																												this.name = "Swiftness Potion";
																																																																																																																																																																												this.useSound = 3;
																																																																																																																																																																												this.useStyle = 2;
																																																																																																																																																																												this.useTurn = true;
																																																																																																																																																																												this.useAnimation = 17;
																																																																																																																																																																												this.useTime = 17;
																																																																																																																																																																												this.maxStack = 30;
																																																																																																																																																																												this.consumable = true;
																																																																																																																																																																												this.width = 14;
																																																																																																																																																																												this.height = 24;
																																																																																																																																																																												this.buffType = 3;
																																																																																																																																																																												this.buffTime = 14400;
																																																																																																																																																																												this.toolTip = "25% increased movement speed";
																																																																																																																																																																												this.value = 1000;
																																																																																																																																																																												this.rare = 1;
																																																																																																																																																																											}
																																																																																																																																																																											else
																																																																																																																																																																											{
																																																																																																																																																																												if (this.type == 291)
																																																																																																																																																																												{
																																																																																																																																																																													this.name = "Gills Potion";
																																																																																																																																																																													this.useSound = 3;
																																																																																																																																																																													this.useStyle = 2;
																																																																																																																																																																													this.useTurn = true;
																																																																																																																																																																													this.useAnimation = 17;
																																																																																																																																																																													this.useTime = 17;
																																																																																																																																																																													this.maxStack = 30;
																																																																																																																																																																													this.consumable = true;
																																																																																																																																																																													this.width = 14;
																																																																																																																																																																													this.height = 24;
																																																																																																																																																																													this.buffType = 4;
																																																																																																																																																																													this.buffTime = 7200;
																																																																																																																																																																													this.toolTip = "Breathe water instead of air";
																																																																																																																																																																													this.value = 1000;
																																																																																																																																																																													this.rare = 1;
																																																																																																																																																																												}
																																																																																																																																																																												else
																																																																																																																																																																												{
																																																																																																																																																																													if (this.type == 292)
																																																																																																																																																																													{
																																																																																																																																																																														this.name = "Ironskin Potion";
																																																																																																																																																																														this.useSound = 3;
																																																																																																																																																																														this.useStyle = 2;
																																																																																																																																																																														this.useTurn = true;
																																																																																																																																																																														this.useAnimation = 17;
																																																																																																																																																																														this.useTime = 17;
																																																																																																																																																																														this.maxStack = 30;
																																																																																																																																																																														this.consumable = true;
																																																																																																																																																																														this.width = 14;
																																																																																																																																																																														this.height = 24;
																																																																																																																																																																														this.buffType = 5;
																																																																																																																																																																														this.buffTime = 18000;
																																																																																																																																																																														this.toolTip = "Increase defense by 8";
																																																																																																																																																																														this.value = 1000;
																																																																																																																																																																														this.rare = 1;
																																																																																																																																																																													}
																																																																																																																																																																													else
																																																																																																																																																																													{
																																																																																																																																																																														if (this.type == 293)
																																																																																																																																																																														{
																																																																																																																																																																															this.name = "Mana Regeneration Potion";
																																																																																																																																																																															this.useSound = 3;
																																																																																																																																																																															this.useStyle = 2;
																																																																																																																																																																															this.useTurn = true;
																																																																																																																																																																															this.useAnimation = 17;
																																																																																																																																																																															this.useTime = 17;
																																																																																																																																																																															this.maxStack = 30;
																																																																																																																																																																															this.consumable = true;
																																																																																																																																																																															this.width = 14;
																																																																																																																																																																															this.height = 24;
																																																																																																																																																																															this.buffType = 6;
																																																																																																																																																																															this.buffTime = 7200;
																																																																																																																																																																															this.toolTip = "Increased mana regeneration";
																																																																																																																																																																															this.value = 1000;
																																																																																																																																																																															this.rare = 1;
																																																																																																																																																																														}
																																																																																																																																																																														else
																																																																																																																																																																														{
																																																																																																																																																																															if (this.type == 294)
																																																																																																																																																																															{
																																																																																																																																																																																this.name = "Magic Power Potion";
																																																																																																																																																																																this.useSound = 3;
																																																																																																																																																																																this.useStyle = 2;
																																																																																																																																																																																this.useTurn = true;
																																																																																																																																																																																this.useAnimation = 17;
																																																																																																																																																																																this.useTime = 17;
																																																																																																																																																																																this.maxStack = 30;
																																																																																																																																																																																this.consumable = true;
																																																																																																																																																																																this.width = 14;
																																																																																																																																																																																this.height = 24;
																																																																																																																																																																																this.buffType = 7;
																																																																																																																																																																																this.buffTime = 7200;
																																																																																																																																																																																this.toolTip = "20% increased magic damage";
																																																																																																																																																																																this.value = 1000;
																																																																																																																																																																																this.rare = 1;
																																																																																																																																																																															}
																																																																																																																																																																															else
																																																																																																																																																																															{
																																																																																																																																																																																if (this.type == 295)
																																																																																																																																																																																{
																																																																																																																																																																																	this.name = "Featherfall Potion";
																																																																																																																																																																																	this.useSound = 3;
																																																																																																																																																																																	this.useStyle = 2;
																																																																																																																																																																																	this.useTurn = true;
																																																																																																																																																																																	this.useAnimation = 17;
																																																																																																																																																																																	this.useTime = 17;
																																																																																																																																																																																	this.maxStack = 30;
																																																																																																																																																																																	this.consumable = true;
																																																																																																																																																																																	this.width = 14;
																																																																																																																																																																																	this.height = 24;
																																																																																																																																																																																	this.buffType = 8;
																																																																																																																																																																																	this.buffTime = 18000;
																																																																																																																																																																																	this.toolTip = "Slows falling speed";
																																																																																																																																																																																	this.value = 1000;
																																																																																																																																																																																	this.rare = 1;
																																																																																																																																																																																}
																																																																																																																																																																																else
																																																																																																																																																																																{
																																																																																																																																																																																	if (this.type == 296)
																																																																																																																																																																																	{
																																																																																																																																																																																		this.name = "Spelunker Potion";
																																																																																																																																																																																		this.useSound = 3;
																																																																																																																																																																																		this.useStyle = 2;
																																																																																																																																																																																		this.useTurn = true;
																																																																																																																																																																																		this.useAnimation = 17;
																																																																																																																																																																																		this.useTime = 17;
																																																																																																																																																																																		this.maxStack = 30;
																																																																																																																																																																																		this.consumable = true;
																																																																																																																																																																																		this.width = 14;
																																																																																																																																																																																		this.height = 24;
																																																																																																																																																																																		this.buffType = 9;
																																																																																																																																																																																		this.buffTime = 18000;
																																																																																																																																																																																		this.toolTip = "Shows the location of treasure and ore";
																																																																																																																																																																																		this.value = 1000;
																																																																																																																																																																																		this.rare = 1;
																																																																																																																																																																																	}
																																																																																																																																																																																	else
																																																																																																																																																																																	{
																																																																																																																																																																																		if (this.type == 297)
																																																																																																																																																																																		{
																																																																																																																																																																																			this.name = "Invisibility Potion";
																																																																																																																																																																																			this.useSound = 3;
																																																																																																																																																																																			this.useStyle = 2;
																																																																																																																																																																																			this.useTurn = true;
																																																																																																																																																																																			this.useAnimation = 17;
																																																																																																																																																																																			this.useTime = 17;
																																																																																																																																																																																			this.maxStack = 30;
																																																																																																																																																																																			this.consumable = true;
																																																																																																																																																																																			this.width = 14;
																																																																																																																																																																																			this.height = 24;
																																																																																																																																																																																			this.buffType = 10;
																																																																																																																																																																																			this.buffTime = 7200;
																																																																																																																																																																																			this.toolTip = "Grants invisibility";
																																																																																																																																																																																			this.value = 1000;
																																																																																																																																																																																			this.rare = 1;
																																																																																																																																																																																		}
																																																																																																																																																																																		else
																																																																																																																																																																																		{
																																																																																																																																																																																			if (this.type == 298)
																																																																																																																																																																																			{
																																																																																																																																																																																				this.name = "Shine Potion";
																																																																																																																																																																																				this.useSound = 3;
																																																																																																																																																																																				this.useStyle = 2;
																																																																																																																																																																																				this.useTurn = true;
																																																																																																																																																																																				this.useAnimation = 17;
																																																																																																																																																																																				this.useTime = 17;
																																																																																																																																																																																				this.maxStack = 30;
																																																																																																																																																																																				this.consumable = true;
																																																																																																																																																																																				this.width = 14;
																																																																																																																																																																																				this.height = 24;
																																																																																																																																																																																				this.buffType = 11;
																																																																																																																																																																																				this.buffTime = 18000;
																																																																																																																																																																																				this.toolTip = "Emit an aura of light";
																																																																																																																																																																																				this.value = 1000;
																																																																																																																																																																																				this.rare = 1;
																																																																																																																																																																																			}
																																																																																																																																																																																			else
																																																																																																																																																																																			{
																																																																																																																																																																																				if (this.type == 299)
																																																																																																																																																																																				{
																																																																																																																																																																																					this.name = "Night Owl Potion";
																																																																																																																																																																																					this.useSound = 3;
																																																																																																																																																																																					this.useStyle = 2;
																																																																																																																																																																																					this.useTurn = true;
																																																																																																																																																																																					this.useAnimation = 17;
																																																																																																																																																																																					this.useTime = 17;
																																																																																																																																																																																					this.maxStack = 30;
																																																																																																																																																																																					this.consumable = true;
																																																																																																																																																																																					this.width = 14;
																																																																																																																																																																																					this.height = 24;
																																																																																																																																																																																					this.buffType = 12;
																																																																																																																																																																																					this.buffTime = 14400;
																																																																																																																																																																																					this.toolTip = "Increased night vision";
																																																																																																																																																																																					this.value = 1000;
																																																																																																																																																																																					this.rare = 1;
																																																																																																																																																																																				}
																																																																																																																																																																																				else
																																																																																																																																																																																				{
																																																																																																																																																																																					if (this.type == 300)
																																																																																																																																																																																					{
																																																																																																																																																																																						this.name = "Battle Potion";
																																																																																																																																																																																						this.useSound = 3;
																																																																																																																																																																																						this.useStyle = 2;
																																																																																																																																																																																						this.useTurn = true;
																																																																																																																																																																																						this.useAnimation = 17;
																																																																																																																																																																																						this.useTime = 17;
																																																																																																																																																																																						this.maxStack = 30;
																																																																																																																																																																																						this.consumable = true;
																																																																																																																																																																																						this.width = 14;
																																																																																																																																																																																						this.height = 24;
																																																																																																																																																																																						this.buffType = 13;
																																																																																																																																																																																						this.buffTime = 25200;
																																																																																																																																																																																						this.toolTip = "Increase enemy spawn rate";
																																																																																																																																																																																						this.value = 1000;
																																																																																																																																																																																						this.rare = 1;
																																																																																																																																																																																					}
																																																																																																																																																																																					else
																																																																																																																																																																																					{
																																																																																																																																																																																						if (this.type == 301)
																																																																																																																																																																																						{
																																																																																																																																																																																							this.name = "Thorns Potion";
																																																																																																																																																																																							this.useSound = 3;
																																																																																																																																																																																							this.useStyle = 2;
																																																																																																																																																																																							this.useTurn = true;
																																																																																																																																																																																							this.useAnimation = 17;
																																																																																																																																																																																							this.useTime = 17;
																																																																																																																																																																																							this.maxStack = 30;
																																																																																																																																																																																							this.consumable = true;
																																																																																																																																																																																							this.width = 14;
																																																																																																																																																																																							this.height = 24;
																																																																																																																																																																																							this.buffType = 14;
																																																																																																																																																																																							this.buffTime = 7200;
																																																																																																																																																																																							this.toolTip = "Attackers also take damage";
																																																																																																																																																																																							this.value = 1000;
																																																																																																																																																																																							this.rare = 1;
																																																																																																																																																																																						}
																																																																																																																																																																																						else
																																																																																																																																																																																						{
																																																																																																																																																																																							if (this.type == 302)
																																																																																																																																																																																							{
																																																																																																																																																																																								this.name = "Water Walking Potion";
																																																																																																																																																																																								this.useSound = 3;
																																																																																																																																																																																								this.useStyle = 2;
																																																																																																																																																																																								this.useTurn = true;
																																																																																																																																																																																								this.useAnimation = 17;
																																																																																																																																																																																								this.useTime = 17;
																																																																																																																																																																																								this.maxStack = 30;
																																																																																																																																																																																								this.consumable = true;
																																																																																																																																																																																								this.width = 14;
																																																																																																																																																																																								this.height = 24;
																																																																																																																																																																																								this.buffType = 15;
																																																																																																																																																																																								this.buffTime = 18000;
																																																																																																																																																																																								this.toolTip = "Allows the ability to walk on water";
																																																																																																																																																																																								this.value = 1000;
																																																																																																																																																																																								this.rare = 1;
																																																																																																																																																																																							}
																																																																																																																																																																																							else
																																																																																																																																																																																							{
																																																																																																																																																																																								if (this.type == 303)
																																																																																																																																																																																								{
																																																																																																																																																																																									this.name = "Archery Potion";
																																																																																																																																																																																									this.useSound = 3;
																																																																																																																																																																																									this.useStyle = 2;
																																																																																																																																																																																									this.useTurn = true;
																																																																																																																																																																																									this.useAnimation = 17;
																																																																																																																																																																																									this.useTime = 17;
																																																																																																																																																																																									this.maxStack = 30;
																																																																																																																																																																																									this.consumable = true;
																																																																																																																																																																																									this.width = 14;
																																																																																																																																																																																									this.height = 24;
																																																																																																																																																																																									this.buffType = 16;
																																																																																																																																																																																									this.buffTime = 14400;
																																																																																																																																																																																									this.toolTip = "20% increased arrow speed and damage";
																																																																																																																																																																																									this.value = 1000;
																																																																																																																																																																																									this.rare = 1;
																																																																																																																																																																																								}
																																																																																																																																																																																								else
																																																																																																																																																																																								{
																																																																																																																																																																																									if (this.type == 304)
																																																																																																																																																																																									{
																																																																																																																																																																																										this.name = "Hunter Potion";
																																																																																																																																																																																										this.useSound = 3;
																																																																																																																																																																																										this.useStyle = 2;
																																																																																																																																																																																										this.useTurn = true;
																																																																																																																																																																																										this.useAnimation = 17;
																																																																																																																																																																																										this.useTime = 17;
																																																																																																																																																																																										this.maxStack = 30;
																																																																																																																																																																																										this.consumable = true;
																																																																																																																																																																																										this.width = 14;
																																																																																																																																																																																										this.height = 24;
																																																																																																																																																																																										this.buffType = 17;
																																																																																																																																																																																										this.buffTime = 18000;
																																																																																																																																																																																										this.toolTip = "Shows the location of enemies";
																																																																																																																																																																																										this.value = 1000;
																																																																																																																																																																																										this.rare = 1;
																																																																																																																																																																																									}
																																																																																																																																																																																									else
																																																																																																																																																																																									{
																																																																																																																																																																																										if (this.type == 305)
																																																																																																																																																																																										{
																																																																																																																																																																																											this.name = "Gravitation Potion";
																																																																																																																																																																																											this.useSound = 3;
																																																																																																																																																																																											this.useStyle = 2;
																																																																																																																																																																																											this.useTurn = true;
																																																																																																																																																																																											this.useAnimation = 17;
																																																																																																																																																																																											this.useTime = 17;
																																																																																																																																																																																											this.maxStack = 30;
																																																																																																																																																																																											this.consumable = true;
																																																																																																																																																																																											this.width = 14;
																																																																																																																																																																																											this.height = 24;
																																																																																																																																																																																											this.buffType = 18;
																																																																																																																																																																																											this.buffTime = 10800;
																																																																																																																																																																																											this.toolTip = "Allows the control of gravity";
																																																																																																																																																																																											this.value = 1000;
																																																																																																																																																																																											this.rare = 1;
																																																																																																																																																																																										}
																																																																																																																																																																																										else
																																																																																																																																																																																										{
																																																																																																																																																																																											if (this.type == 306)
																																																																																																																																																																																											{
																																																																																																																																																																																												this.name = "Gold Chest";
																																																																																																																																																																																												this.useStyle = 1;
																																																																																																																																																																																												this.useTurn = true;
																																																																																																																																																																																												this.useAnimation = 15;
																																																																																																																																																																																												this.useTime = 10;
																																																																																																																																																																																												this.autoReuse = true;
																																																																																																																																																																																												this.maxStack = 99;
																																																																																																																																																																																												this.consumable = true;
																																																																																																																																																																																												this.createTile = 21;
																																																																																																																																																																																												this.placeStyle = 1;
																																																																																																																																																																																												this.width = 26;
																																																																																																																																																																																												this.height = 22;
																																																																																																																																																																																												this.value = 5000;
																																																																																																																																																																																											}
																																																																																																																																																																																											else
																																																																																																																																																																																											{
																																																																																																																																																																																												if (this.type == 307)
																																																																																																																																																																																												{
																																																																																																																																																																																													this.name = "Daybloom Seeds";
																																																																																																																																																																																													this.useTurn = true;
																																																																																																																																																																																													this.useStyle = 1;
																																																																																																																																																																																													this.useAnimation = 15;
																																																																																																																																																																																													this.useTime = 10;
																																																																																																																																																																																													this.maxStack = 99;
																																																																																																																																																																																													this.consumable = true;
																																																																																																																																																																																													this.createTile = 82;
																																																																																																																																																																																													this.placeStyle = 0;
																																																																																																																																																																																													this.width = 12;
																																																																																																																																																																																													this.height = 14;
																																																																																																																																																																																													this.value = 80;
																																																																																																																																																																																												}
																																																																																																																																																																																												else
																																																																																																																																																																																												{
																																																																																																																																																																																													if (this.type == 308)
																																																																																																																																																																																													{
																																																																																																																																																																																														this.name = "Moonglow Seeds";
																																																																																																																																																																																														this.useTurn = true;
																																																																																																																																																																																														this.useStyle = 1;
																																																																																																																																																																																														this.useAnimation = 15;
																																																																																																																																																																																														this.useTime = 10;
																																																																																																																																																																																														this.maxStack = 99;
																																																																																																																																																																																														this.consumable = true;
																																																																																																																																																																																														this.createTile = 82;
																																																																																																																																																																																														this.placeStyle = 1;
																																																																																																																																																																																														this.width = 12;
																																																																																																																																																																																														this.height = 14;
																																																																																																																																																																																														this.value = 80;
																																																																																																																																																																																													}
																																																																																																																																																																																													else
																																																																																																																																																																																													{
																																																																																																																																																																																														if (this.type == 309)
																																																																																																																																																																																														{
																																																																																																																																																																																															this.name = "Blinkroot Seeds";
																																																																																																																																																																																															this.useTurn = true;
																																																																																																																																																																																															this.useStyle = 1;
																																																																																																																																																																																															this.useAnimation = 15;
																																																																																																																																																																																															this.useTime = 10;
																																																																																																																																																																																															this.maxStack = 99;
																																																																																																																																																																																															this.consumable = true;
																																																																																																																																																																																															this.createTile = 82;
																																																																																																																																																																																															this.placeStyle = 2;
																																																																																																																																																																																															this.width = 12;
																																																																																																																																																																																															this.height = 14;
																																																																																																																																																																																															this.value = 80;
																																																																																																																																																																																														}
																																																																																																																																																																																														else
																																																																																																																																																																																														{
																																																																																																																																																																																															if (this.type == 310)
																																																																																																																																																																																															{
																																																																																																																																																																																																this.name = "Deathweed Seeds";
																																																																																																																																																																																																this.useTurn = true;
																																																																																																																																																																																																this.useStyle = 1;
																																																																																																																																																																																																this.useAnimation = 15;
																																																																																																																																																																																																this.useTime = 10;
																																																																																																																																																																																																this.maxStack = 99;
																																																																																																																																																																																																this.consumable = true;
																																																																																																																																																																																																this.createTile = 82;
																																																																																																																																																																																																this.placeStyle = 3;
																																																																																																																																																																																																this.width = 12;
																																																																																																																																																																																																this.height = 14;
																																																																																																																																																																																																this.value = 80;
																																																																																																																																																																																															}
																																																																																																																																																																																															else
																																																																																																																																																																																															{
																																																																																																																																																																																																if (this.type == 311)
																																																																																																																																																																																																{
																																																																																																																																																																																																	this.name = "Waterleaf Seeds";
																																																																																																																																																																																																	this.useTurn = true;
																																																																																																																																																																																																	this.useStyle = 1;
																																																																																																																																																																																																	this.useAnimation = 15;
																																																																																																																																																																																																	this.useTime = 10;
																																																																																																																																																																																																	this.maxStack = 99;
																																																																																																																																																																																																	this.consumable = true;
																																																																																																																																																																																																	this.createTile = 82;
																																																																																																																																																																																																	this.placeStyle = 4;
																																																																																																																																																																																																	this.width = 12;
																																																																																																																																																																																																	this.height = 14;
																																																																																																																																																																																																	this.value = 80;
																																																																																																																																																																																																}
																																																																																																																																																																																																else
																																																																																																																																																																																																{
																																																																																																																																																																																																	if (this.type == 312)
																																																																																																																																																																																																	{
																																																																																																																																																																																																		this.name = "Fireblossom Seeds";
																																																																																																																																																																																																		this.useTurn = true;
																																																																																																																																																																																																		this.useStyle = 1;
																																																																																																																																																																																																		this.useAnimation = 15;
																																																																																																																																																																																																		this.useTime = 10;
																																																																																																																																																																																																		this.maxStack = 99;
																																																																																																																																																																																																		this.consumable = true;
																																																																																																																																																																																																		this.createTile = 82;
																																																																																																																																																																																																		this.placeStyle = 5;
																																																																																																																																																																																																		this.width = 12;
																																																																																																																																																																																																		this.height = 14;
																																																																																																																																																																																																		this.value = 80;
																																																																																																																																																																																																	}
																																																																																																																																																																																																	else
																																																																																																																																																																																																	{
																																																																																																																																																																																																		if (this.type == 313)
																																																																																																																																																																																																		{
																																																																																																																																																																																																			this.name = "Daybloom";
																																																																																																																																																																																																			this.maxStack = 99;
																																																																																																																																																																																																			this.width = 12;
																																																																																																																																																																																																			this.height = 14;
																																																																																																																																																																																																			this.value = 100;
																																																																																																																																																																																																		}
																																																																																																																																																																																																		else
																																																																																																																																																																																																		{
																																																																																																																																																																																																			if (this.type == 314)
																																																																																																																																																																																																			{
																																																																																																																																																																																																				this.name = "Moonglow";
																																																																																																																																																																																																				this.maxStack = 99;
																																																																																																																																																																																																				this.width = 12;
																																																																																																																																																																																																				this.height = 14;
																																																																																																																																																																																																				this.value = 100;
																																																																																																																																																																																																			}
																																																																																																																																																																																																			else
																																																																																																																																																																																																			{
																																																																																																																																																																																																				if (this.type == 315)
																																																																																																																																																																																																				{
																																																																																																																																																																																																					this.name = "Blinkroot";
																																																																																																																																																																																																					this.maxStack = 99;
																																																																																																																																																																																																					this.width = 12;
																																																																																																																																																																																																					this.height = 14;
																																																																																																																																																																																																					this.value = 100;
																																																																																																																																																																																																				}
																																																																																																																																																																																																				else
																																																																																																																																																																																																				{
																																																																																																																																																																																																					if (this.type == 316)
																																																																																																																																																																																																					{
																																																																																																																																																																																																						this.name = "Deathweed";
																																																																																																																																																																																																						this.maxStack = 99;
																																																																																																																																																																																																						this.width = 12;
																																																																																																																																																																																																						this.height = 14;
																																																																																																																																																																																																						this.value = 100;
																																																																																																																																																																																																					}
																																																																																																																																																																																																					else
																																																																																																																																																																																																					{
																																																																																																																																																																																																						if (this.type == 317)
																																																																																																																																																																																																						{
																																																																																																																																																																																																							this.name = "Waterleaf";
																																																																																																																																																																																																							this.maxStack = 99;
																																																																																																																																																																																																							this.width = 12;
																																																																																																																																																																																																							this.height = 14;
																																																																																																																																																																																																							this.value = 100;
																																																																																																																																																																																																						}
																																																																																																																																																																																																						else
																																																																																																																																																																																																						{
																																																																																																																																																																																																							if (this.type == 318)
																																																																																																																																																																																																							{
																																																																																																																																																																																																								this.name = "Fireblossom";
																																																																																																																																																																																																								this.maxStack = 99;
																																																																																																																																																																																																								this.width = 12;
																																																																																																																																																																																																								this.height = 14;
																																																																																																																																																																																																								this.value = 100;
																																																																																																																																																																																																							}
																																																																																																																																																																																																							else
																																																																																																																																																																																																							{
																																																																																																																																																																																																								if (this.type == 319)
																																																																																																																																																																																																								{
																																																																																																																																																																																																									this.name = "Shark Fin";
																																																																																																																																																																																																									this.maxStack = 99;
																																																																																																																																																																																																									this.width = 16;
																																																																																																																																																																																																									this.height = 14;
																																																																																																																																																																																																									this.value = 200;
																																																																																																																																																																																																								}
																																																																																																																																																																																																								else
																																																																																																																																																																																																								{
																																																																																																																																																																																																									if (this.type == 320)
																																																																																																																																																																																																									{
																																																																																																																																																																																																										this.name = "Feather";
																																																																																																																																																																																																										this.maxStack = 99;
																																																																																																																																																																																																										this.width = 16;
																																																																																																																																																																																																										this.height = 14;
																																																																																																																																																																																																										this.value = 50;
																																																																																																																																																																																																									}
																																																																																																																																																																																																									else
																																																																																																																																																																																																									{
																																																																																																																																																																																																										if (this.type == 321)
																																																																																																																																																																																																										{
																																																																																																																																																																																																											this.name = "Tombstone";
																																																																																																																																																																																																											this.useTurn = true;
																																																																																																																																																																																																											this.useStyle = 1;
																																																																																																																																																																																																											this.useAnimation = 15;
																																																																																																																																																																																																											this.useTime = 10;
																																																																																																																																																																																																											this.maxStack = 99;
																																																																																																																																																																																																											this.consumable = true;
																																																																																																																																																																																																											this.createTile = 85;
																																																																																																																																																																																																											this.width = 20;
																																																																																																																																																																																																											this.height = 20;
																																																																																																																																																																																																										}
																																																																																																																																																																																																										else
																																																																																																																																																																																																										{
																																																																																																																																																																																																											if (this.type == 322)
																																																																																																																																																																																																											{
																																																																																																																																																																																																												this.name = "Mime Mask";
																																																																																																																																																																																																												this.headSlot = 28;
																																																																																																																																																																																																												this.width = 20;
																																																																																																																																																																																																												this.height = 20;
																																																																																																																																																																																																												this.value = 20000;
																																																																																																																																																																																																											}
																																																																																																																																																																																																											else
																																																																																																																																																																																																											{
																																																																																																																																																																																																												if (this.type == 323)
																																																																																																																																																																																																												{
																																																																																																																																																																																																													this.name = "Antlion Mandible";
																																																																																																																																																																																																													this.width = 10;
																																																																																																																																																																																																													this.height = 20;
																																																																																																																																																																																																													this.maxStack = 99;
																																																																																																																																																																																																													this.value = 50;
																																																																																																																																																																																																												}
																																																																																																																																																																																																												else
																																																																																																																																																																																																												{
																																																																																																																																																																																																													if (this.type == 324)
																																																																																																																																																																																																													{
																																																																																																																																																																																																														this.name = "Illegal Gun Parts";
																																																																																																																																																																																																														this.width = 10;
																																																																																																																																																																																																														this.height = 20;
																																																																																																																																																																																																														this.maxStack = 99;
																																																																																																																																																																																																														this.value = 1000000;
																																																																																																																																																																																																														this.toolTip = "'Banned in most places'";
																																																																																																																																																																																																													}
																																																																																																																																																																																																													else
																																																																																																																																																																																																													{
																																																																																																																																																																																																														if (this.type == 325)
																																																																																																																																																																																																														{
																																																																																																																																																																																																															this.name = "The Doctor's Shirt";
																																																																																																																																																																																																															this.width = 18;
																																																																																																																																																																																																															this.height = 18;
																																																																																																																																																																																																															this.bodySlot = 16;
																																																																																																																																																																																																															this.value = 200000;
																																																																																																																																																																																																															this.vanity = true;
																																																																																																																																																																																																														}
																																																																																																																																																																																																														else
																																																																																																																																																																																																														{
																																																																																																																																																																																																															if (this.type == 326)
																																																																																																																																																																																																															{
																																																																																																																																																																																																																this.name = "The Doctor's Pants";
																																																																																																																																																																																																																this.width = 18;
																																																																																																																																																																																																																this.height = 18;
																																																																																																																																																																																																																this.legSlot = 15;
																																																																																																																																																																																																																this.value = 200000;
																																																																																																																																																																																																																this.vanity = true;
																																																																																																																																																																																																															}
																																																																																																																																																																																																															else
																																																																																																																																																																																																															{
																																																																																																																																																																																																																if (this.type == 327)
																																																																																																																																																																																																																{
																																																																																																																																																																																																																	this.name = "Golden Key";
																																																																																																																																																																																																																	this.width = 14;
																																																																																																																																																																																																																	this.height = 20;
																																																																																																																																																																																																																	this.maxStack = 99;
																																																																																																																																																																																																																	this.toolTip = "Opens one Gold Chest";
																																																																																																																																																																																																																}
																																																																																																																																																																																																																else
																																																																																																																																																																																																																{
																																																																																																																																																																																																																	if (this.type == 328)
																																																																																																																																																																																																																	{
																																																																																																																																																																																																																		this.name = "Shadow Chest";
																																																																																																																																																																																																																		this.useStyle = 1;
																																																																																																																																																																																																																		this.useTurn = true;
																																																																																																																																																																																																																		this.useAnimation = 15;
																																																																																																																																																																																																																		this.useTime = 10;
																																																																																																																																																																																																																		this.autoReuse = true;
																																																																																																																																																																																																																		this.maxStack = 99;
																																																																																																																																																																																																																		this.consumable = true;
																																																																																																																																																																																																																		this.createTile = 21;
																																																																																																																																																																																																																		this.placeStyle = 3;
																																																																																																																																																																																																																		this.width = 26;
																																																																																																																																																																																																																		this.height = 22;
																																																																																																																																																																																																																		this.value = 5000;
																																																																																																																																																																																																																	}
																																																																																																																																																																																																																	else
																																																																																																																																																																																																																	{
																																																																																																																																																																																																																		if (this.type == 329)
																																																																																																																																																																																																																		{
																																																																																																																																																																																																																			this.name = "Shadow Key";
																																																																																																																																																																																																																			this.width = 14;
																																																																																																																																																																																																																			this.height = 20;
																																																																																																																																																																																																																			this.maxStack = 1;
																																																																																																																																																																																																																			this.toolTip = "Opens all Shadow Chests";
																																																																																																																																																																																																																		}
																																																																																																																																																																																																																		else
																																																																																																																																																																																																																		{
																																																																																																																																																																																																																			if (this.type == 330)
																																																																																																																																																																																																																			{
																																																																																																																																																																																																																				this.name = "Obsidian Brick Wall";
																																																																																																																																																																																																																				this.useStyle = 1;
																																																																																																																																																																																																																				this.useTurn = true;
																																																																																																																																																																																																																				this.useAnimation = 15;
																																																																																																																																																																																																																				this.useTime = 7;
																																																																																																																																																																																																																				this.autoReuse = true;
																																																																																																																																																																																																																				this.maxStack = 250;
																																																																																																																																																																																																																				this.consumable = true;
																																																																																																																																																																																																																				this.createWall = 20;
																																																																																																																																																																																																																				this.width = 12;
																																																																																																																																																																																																																				this.height = 12;
																																																																																																																																																																																																																			}
																																																																																																																																																																																																																			else
																																																																																																																																																																																																																			{
																																																																																																																																																																																																																				if (this.type == 331)
																																																																																																																																																																																																																				{
																																																																																																																																																																																																																					this.name = "Jungle Spores";
																																																																																																																																																																																																																					this.width = 18;
																																																																																																																																																																																																																					this.height = 16;
																																																																																																																																																																																																																					this.maxStack = 99;
																																																																																																																																																																																																																					this.value = 100;
																																																																																																																																																																																																																				}
																																																																																																																																																																																																																				else
																																																																																																																																																																																																																				{
																																																																																																																																																																																																																					if (this.type == 332)
																																																																																																																																																																																																																					{
																																																																																																																																																																																																																						this.name = "Loom";
																																																																																																																																																																																																																						this.useStyle = 1;
																																																																																																																																																																																																																						this.useTurn = true;
																																																																																																																																																																																																																						this.useAnimation = 15;
																																																																																																																																																																																																																						this.useTime = 10;
																																																																																																																																																																																																																						this.autoReuse = true;
																																																																																																																																																																																																																						this.maxStack = 99;
																																																																																																																																																																																																																						this.consumable = true;
																																																																																																																																																																																																																						this.createTile = 86;
																																																																																																																																																																																																																						this.width = 20;
																																																																																																																																																																																																																						this.height = 20;
																																																																																																																																																																																																																						this.value = 300;
																																																																																																																																																																																																																						this.toolTip = "Used for crafting cloth";
																																																																																																																																																																																																																					}
																																																																																																																																																																																																																					else
																																																																																																																																																																																																																					{
																																																																																																																																																																																																																						if (this.type == 333)
																																																																																																																																																																																																																						{
																																																																																																																																																																																																																							this.name = "Piano";
																																																																																																																																																																																																																							this.useStyle = 1;
																																																																																																																																																																																																																							this.useTurn = true;
																																																																																																																																																																																																																							this.useAnimation = 15;
																																																																																																																																																																																																																							this.useTime = 10;
																																																																																																																																																																																																																							this.autoReuse = true;
																																																																																																																																																																																																																							this.maxStack = 99;
																																																																																																																																																																																																																							this.consumable = true;
																																																																																																																																																																																																																							this.createTile = 87;
																																																																																																																																																																																																																							this.width = 20;
																																																																																																																																																																																																																							this.height = 20;
																																																																																																																																																																																																																							this.value = 300;
																																																																																																																																																																																																																						}
																																																																																																																																																																																																																						else
																																																																																																																																																																																																																						{
																																																																																																																																																																																																																							if (this.type == 334)
																																																																																																																																																																																																																							{
																																																																																																																																																																																																																								this.name = "Dresser";
																																																																																																																																																																																																																								this.useStyle = 1;
																																																																																																																																																																																																																								this.useTurn = true;
																																																																																																																																																																																																																								this.useAnimation = 15;
																																																																																																																																																																																																																								this.useTime = 10;
																																																																																																																																																																																																																								this.autoReuse = true;
																																																																																																																																																																																																																								this.maxStack = 99;
																																																																																																																																																																																																																								this.consumable = true;
																																																																																																																																																																																																																								this.createTile = 88;
																																																																																																																																																																																																																								this.width = 20;
																																																																																																																																																																																																																								this.height = 20;
																																																																																																																																																																																																																								this.value = 300;
																																																																																																																																																																																																																							}
																																																																																																																																																																																																																							else
																																																																																																																																																																																																																							{
																																																																																																																																																																																																																								if (this.type == 335)
																																																																																																																																																																																																																								{
																																																																																																																																																																																																																									this.name = "Bench";
																																																																																																																																																																																																																									this.useStyle = 1;
																																																																																																																																																																																																																									this.useTurn = true;
																																																																																																																																																																																																																									this.useAnimation = 15;
																																																																																																																																																																																																																									this.useTime = 10;
																																																																																																																																																																																																																									this.autoReuse = true;
																																																																																																																																																																																																																									this.maxStack = 99;
																																																																																																																																																																																																																									this.consumable = true;
																																																																																																																																																																																																																									this.createTile = 89;
																																																																																																																																																																																																																									this.width = 20;
																																																																																																																																																																																																																									this.height = 20;
																																																																																																																																																																																																																									this.value = 300;
																																																																																																																																																																																																																								}
																																																																																																																																																																																																																								else
																																																																																																																																																																																																																								{
																																																																																																																																																																																																																									if (this.type == 336)
																																																																																																																																																																																																																									{
																																																																																																																																																																																																																										this.name = "Bathtub";
																																																																																																																																																																																																																										this.useStyle = 1;
																																																																																																																																																																																																																										this.useTurn = true;
																																																																																																																																																																																																																										this.useAnimation = 15;
																																																																																																																																																																																																																										this.useTime = 10;
																																																																																																																																																																																																																										this.autoReuse = true;
																																																																																																																																																																																																																										this.maxStack = 99;
																																																																																																																																																																																																																										this.consumable = true;
																																																																																																																																																																																																																										this.createTile = 90;
																																																																																																																																																																																																																										this.width = 20;
																																																																																																																																																																																																																										this.height = 20;
																																																																																																																																																																																																																										this.value = 300;
																																																																																																																																																																																																																									}
																																																																																																																																																																																																																									else
																																																																																																																																																																																																																									{
																																																																																																																																																																																																																										if (this.type == 337)
																																																																																																																																																																																																																										{
																																																																																																																																																																																																																											this.name = "Red Banner";
																																																																																																																																																																																																																											this.useStyle = 1;
																																																																																																																																																																																																																											this.useTurn = true;
																																																																																																																																																																																																																											this.useAnimation = 15;
																																																																																																																																																																																																																											this.useTime = 10;
																																																																																																																																																																																																																											this.autoReuse = true;
																																																																																																																																																																																																																											this.maxStack = 99;
																																																																																																																																																																																																																											this.consumable = true;
																																																																																																																																																																																																																											this.createTile = 91;
																																																																																																																																																																																																																											this.placeStyle = 0;
																																																																																																																																																																																																																											this.width = 10;
																																																																																																																																																																																																																											this.height = 24;
																																																																																																																																																																																																																											this.value = 500;
																																																																																																																																																																																																																										}
																																																																																																																																																																																																																										else
																																																																																																																																																																																																																										{
																																																																																																																																																																																																																											if (this.type == 338)
																																																																																																																																																																																																																											{
																																																																																																																																																																																																																												this.name = "Green Banner";
																																																																																																																																																																																																																												this.useStyle = 1;
																																																																																																																																																																																																																												this.useTurn = true;
																																																																																																																																																																																																																												this.useAnimation = 15;
																																																																																																																																																																																																																												this.useTime = 10;
																																																																																																																																																																																																																												this.autoReuse = true;
																																																																																																																																																																																																																												this.maxStack = 99;
																																																																																																																																																																																																																												this.consumable = true;
																																																																																																																																																																																																																												this.createTile = 91;
																																																																																																																																																																																																																												this.placeStyle = 1;
																																																																																																																																																																																																																												this.width = 10;
																																																																																																																																																																																																																												this.height = 24;
																																																																																																																																																																																																																												this.value = 500;
																																																																																																																																																																																																																											}
																																																																																																																																																																																																																											else
																																																																																																																																																																																																																											{
																																																																																																																																																																																																																												if (this.type == 339)
																																																																																																																																																																																																																												{
																																																																																																																																																																																																																													this.name = "Blue Banner";
																																																																																																																																																																																																																													this.useStyle = 1;
																																																																																																																																																																																																																													this.useTurn = true;
																																																																																																																																																																																																																													this.useAnimation = 15;
																																																																																																																																																																																																																													this.useTime = 10;
																																																																																																																																																																																																																													this.autoReuse = true;
																																																																																																																																																																																																																													this.maxStack = 99;
																																																																																																																																																																																																																													this.consumable = true;
																																																																																																																																																																																																																													this.createTile = 91;
																																																																																																																																																																																																																													this.placeStyle = 2;
																																																																																																																																																																																																																													this.width = 10;
																																																																																																																																																																																																																													this.height = 24;
																																																																																																																																																																																																																													this.value = 500;
																																																																																																																																																																																																																												}
																																																																																																																																																																																																																												else
																																																																																																																																																																																																																												{
																																																																																																																																																																																																																													if (this.type == 340)
																																																																																																																																																																																																																													{
																																																																																																																																																																																																																														this.name = "Yellow Banner";
																																																																																																																																																																																																																														this.useStyle = 1;
																																																																																																																																																																																																																														this.useTurn = true;
																																																																																																																																																																																																																														this.useAnimation = 15;
																																																																																																																																																																																																																														this.useTime = 10;
																																																																																																																																																																																																																														this.autoReuse = true;
																																																																																																																																																																																																																														this.maxStack = 99;
																																																																																																																																																																																																																														this.consumable = true;
																																																																																																																																																																																																																														this.createTile = 91;
																																																																																																																																																																																																																														this.placeStyle = 3;
																																																																																																																																																																																																																														this.width = 10;
																																																																																																																																																																																																																														this.height = 24;
																																																																																																																																																																																																																														this.value = 500;
																																																																																																																																																																																																																													}
																																																																																																																																																																																																																													else
																																																																																																																																																																																																																													{
																																																																																																																																																																																																																														if (this.type == 341)
																																																																																																																																																																																																																														{
																																																																																																																																																																																																																															this.name = "Lamp Post";
																																																																																																																																																																																																																															this.useStyle = 1;
																																																																																																																																																																																																																															this.useTurn = true;
																																																																																																																																																																																																																															this.useAnimation = 15;
																																																																																																																																																																																																																															this.useTime = 10;
																																																																																																																																																																																																																															this.autoReuse = true;
																																																																																																																																																																																																																															this.maxStack = 99;
																																																																																																																																																																																																																															this.consumable = true;
																																																																																																																																																																																																																															this.createTile = 92;
																																																																																																																																																																																																																															this.width = 10;
																																																																																																																																																																																																																															this.height = 24;
																																																																																																																																																																																																																															this.value = 500;
																																																																																																																																																																																																																														}
																																																																																																																																																																																																																														else
																																																																																																																																																																																																																														{
																																																																																																																																																																																																																															if (this.type == 342)
																																																																																																																																																																																																																															{
																																																																																																																																																																																																																																this.name = "Tiki Torch";
																																																																																																																																																																																																																																this.useStyle = 1;
																																																																																																																																																																																																																																this.useTurn = true;
																																																																																																																																																																																																																																this.useAnimation = 15;
																																																																																																																																																																																																																																this.useTime = 10;
																																																																																																																																																																																																																																this.autoReuse = true;
																																																																																																																																																																																																																																this.maxStack = 99;
																																																																																																																																																																																																																																this.consumable = true;
																																																																																																																																																																																																																																this.createTile = 93;
																																																																																																																																																																																																																																this.width = 10;
																																																																																																																																																																																																																																this.height = 24;
																																																																																																																																																																																																																																this.value = 500;
																																																																																																																																																																																																																															}
																																																																																																																																																																																																																															else
																																																																																																																																																																																																																															{
																																																																																																																																																																																																																																if (this.type == 343)
																																																																																																																																																																																																																																{
																																																																																																																																																																																																																																	this.name = "Barrel";
																																																																																																																																																																																																																																	this.useStyle = 1;
																																																																																																																																																																																																																																	this.useTurn = true;
																																																																																																																																																																																																																																	this.useAnimation = 15;
																																																																																																																																																																																																																																	this.useTime = 10;
																																																																																																																																																																																																																																	this.autoReuse = true;
																																																																																																																																																																																																																																	this.maxStack = 99;
																																																																																																																																																																																																																																	this.consumable = true;
																																																																																																																																																																																																																																	this.createTile = 21;
																																																																																																																																																																																																																																	this.placeStyle = 5;
																																																																																																																																																																																																																																	this.width = 20;
																																																																																																																																																																																																																																	this.height = 20;
																																																																																																																																																																																																																																	this.value = 500;
																																																																																																																																																																																																																																}
																																																																																																																																																																																																																																else
																																																																																																																																																																																																																																{
																																																																																																																																																																																																																																	if (this.type == 344)
																																																																																																																																																																																																																																	{
																																																																																																																																																																																																																																		this.name = "Chinese Lantern";
																																																																																																																																																																																																																																		this.useStyle = 1;
																																																																																																																																																																																																																																		this.useTurn = true;
																																																																																																																																																																																																																																		this.useAnimation = 15;
																																																																																																																																																																																																																																		this.useTime = 10;
																																																																																																																																																																																																																																		this.autoReuse = true;
																																																																																																																																																																																																																																		this.maxStack = 99;
																																																																																																																																																																																																																																		this.consumable = true;
																																																																																																																																																																																																																																		this.createTile = 95;
																																																																																																																																																																																																																																		this.width = 20;
																																																																																																																																																																																																																																		this.height = 20;
																																																																																																																																																																																																																																		this.value = 500;
																																																																																																																																																																																																																																	}
																																																																																																																																																																																																																																	else
																																																																																																																																																																																																																																	{
																																																																																																																																																																																																																																		if (this.type == 345)
																																																																																																																																																																																																																																		{
																																																																																																																																																																																																																																			this.name = "Cooking Pot";
																																																																																																																																																																																																																																			this.useStyle = 1;
																																																																																																																																																																																																																																			this.useTurn = true;
																																																																																																																																																																																																																																			this.useAnimation = 15;
																																																																																																																																																																																																																																			this.useTime = 10;
																																																																																																																																																																																																																																			this.autoReuse = true;
																																																																																																																																																																																																																																			this.maxStack = 99;
																																																																																																																																																																																																																																			this.consumable = true;
																																																																																																																																																																																																																																			this.createTile = 96;
																																																																																																																																																																																																																																			this.width = 20;
																																																																																																																																																																																																																																			this.height = 20;
																																																																																																																																																																																																																																			this.value = 500;
																																																																																																																																																																																																																																		}
																																																																																																																																																																																																																																		else
																																																																																																																																																																																																																																		{
																																																																																																																																																																																																																																			if (this.type == 346)
																																																																																																																																																																																																																																			{
																																																																																																																																																																																																																																				this.name = "Safe";
																																																																																																																																																																																																																																				this.useStyle = 1;
																																																																																																																																																																																																																																				this.useTurn = true;
																																																																																																																																																																																																																																				this.useAnimation = 15;
																																																																																																																																																																																																																																				this.useTime = 10;
																																																																																																																																																																																																																																				this.autoReuse = true;
																																																																																																																																																																																																																																				this.maxStack = 99;
																																																																																																																																																																																																																																				this.consumable = true;
																																																																																																																																																																																																																																				this.createTile = 97;
																																																																																																																																																																																																																																				this.width = 20;
																																																																																																																																																																																																																																				this.height = 20;
																																																																																																																																																																																																																																				this.value = 500000;
																																																																																																																																																																																																																																			}
																																																																																																																																																																																																																																			else
																																																																																																																																																																																																																																			{
																																																																																																																																																																																																																																				if (this.type == 347)
																																																																																																																																																																																																																																				{
																																																																																																																																																																																																																																					this.name = "Skull Lantern";
																																																																																																																																																																																																																																					this.useStyle = 1;
																																																																																																																																																																																																																																					this.useTurn = true;
																																																																																																																																																																																																																																					this.useAnimation = 15;
																																																																																																																																																																																																																																					this.useTime = 10;
																																																																																																																																																																																																																																					this.autoReuse = true;
																																																																																																																																																																																																																																					this.maxStack = 99;
																																																																																																																																																																																																																																					this.consumable = true;
																																																																																																																																																																																																																																					this.createTile = 98;
																																																																																																																																																																																																																																					this.width = 20;
																																																																																																																																																																																																																																					this.height = 20;
																																																																																																																																																																																																																																					this.value = 500;
																																																																																																																																																																																																																																				}
																																																																																																																																																																																																																																				else
																																																																																																																																																																																																																																				{
																																																																																																																																																																																																																																					if (this.type == 348)
																																																																																																																																																																																																																																					{
																																																																																																																																																																																																																																						this.name = "Trash Can";
																																																																																																																																																																																																																																						this.useStyle = 1;
																																																																																																																																																																																																																																						this.useTurn = true;
																																																																																																																																																																																																																																						this.useAnimation = 15;
																																																																																																																																																																																																																																						this.useTime = 10;
																																																																																																																																																																																																																																						this.autoReuse = true;
																																																																																																																																																																																																																																						this.maxStack = 99;
																																																																																																																																																																																																																																						this.consumable = true;
																																																																																																																																																																																																																																						this.createTile = 21;
																																																																																																																																																																																																																																						this.placeStyle = 6;
																																																																																																																																																																																																																																						this.width = 20;
																																																																																																																																																																																																																																						this.height = 20;
																																																																																																																																																																																																																																						this.value = 1000;
																																																																																																																																																																																																																																					}
																																																																																																																																																																																																																																					else
																																																																																																																																																																																																																																					{
																																																																																																																																																																																																																																						if (this.type == 349)
																																																																																																																																																																																																																																						{
																																																																																																																																																																																																																																							this.name = "Candelabra";
																																																																																																																																																																																																																																							this.useStyle = 1;
																																																																																																																																																																																																																																							this.useTurn = true;
																																																																																																																																																																																																																																							this.useAnimation = 15;
																																																																																																																																																																																																																																							this.useTime = 10;
																																																																																																																																																																																																																																							this.autoReuse = true;
																																																																																																																																																																																																																																							this.maxStack = 99;
																																																																																																																																																																																																																																							this.consumable = true;
																																																																																																																																																																																																																																							this.createTile = 100;
																																																																																																																																																																																																																																							this.width = 20;
																																																																																																																																																																																																																																							this.height = 20;
																																																																																																																																																																																																																																							this.value = 1500;
																																																																																																																																																																																																																																						}
																																																																																																																																																																																																																																						else
																																																																																																																																																																																																																																						{
																																																																																																																																																																																																																																							if (this.type == 350)
																																																																																																																																																																																																																																							{
																																																																																																																																																																																																																																								this.name = "Pink Vase";
																																																																																																																																																																																																																																								this.useStyle = 1;
																																																																																																																																																																																																																																								this.useTurn = true;
																																																																																																																																																																																																																																								this.useAnimation = 15;
																																																																																																																																																																																																																																								this.useTime = 10;
																																																																																																																																																																																																																																								this.autoReuse = true;
																																																																																																																																																																																																																																								this.maxStack = 99;
																																																																																																																																																																																																																																								this.consumable = true;
																																																																																																																																																																																																																																								this.createTile = 13;
																																																																																																																																																																																																																																								this.placeStyle = 3;
																																																																																																																																																																																																																																								this.width = 16;
																																																																																																																																																																																																																																								this.height = 24;
																																																																																																																																																																																																																																								this.value = 70;
																																																																																																																																																																																																																																							}
																																																																																																																																																																																																																																							else
																																																																																																																																																																																																																																							{
																																																																																																																																																																																																																																								if (this.type == 351)
																																																																																																																																																																																																																																								{
																																																																																																																																																																																																																																									this.name = "Mug";
																																																																																																																																																																																																																																									this.useStyle = 1;
																																																																																																																																																																																																																																									this.useTurn = true;
																																																																																																																																																																																																																																									this.useAnimation = 15;
																																																																																																																																																																																																																																									this.useTime = 10;
																																																																																																																																																																																																																																									this.autoReuse = true;
																																																																																																																																																																																																																																									this.maxStack = 99;
																																																																																																																																																																																																																																									this.consumable = true;
																																																																																																																																																																																																																																									this.createTile = 13;
																																																																																																																																																																																																																																									this.placeStyle = 4;
																																																																																																																																																																																																																																									this.width = 16;
																																																																																																																																																																																																																																									this.height = 24;
																																																																																																																																																																																																																																									this.value = 20;
																																																																																																																																																																																																																																								}
																																																																																																																																																																																																																																								else
																																																																																																																																																																																																																																								{
																																																																																																																																																																																																																																									if (this.type == 352)
																																																																																																																																																																																																																																									{
																																																																																																																																																																																																																																										this.name = "Keg";
																																																																																																																																																																																																																																										this.useStyle = 1;
																																																																																																																																																																																																																																										this.useTurn = true;
																																																																																																																																																																																																																																										this.useAnimation = 15;
																																																																																																																																																																																																																																										this.useTime = 10;
																																																																																																																																																																																																																																										this.autoReuse = true;
																																																																																																																																																																																																																																										this.maxStack = 99;
																																																																																																																																																																																																																																										this.consumable = true;
																																																																																																																																																																																																																																										this.createTile = 94;
																																																																																																																																																																																																																																										this.width = 24;
																																																																																																																																																																																																																																										this.height = 24;
																																																																																																																																																																																																																																										this.value = 600;
																																																																																																																																																																																																																																										this.toolTip = "Used for brewing ale";
																																																																																																																																																																																																																																									}
																																																																																																																																																																																																																																									else
																																																																																																																																																																																																																																									{
																																																																																																																																																																																																																																										if (this.type == 353)
																																																																																																																																																																																																																																										{
																																																																																																																																																																																																																																											this.name = "Ale";
																																																																																																																																																																																																																																											this.useSound = 3;
																																																																																																																																																																																																																																											this.useStyle = 2;
																																																																																																																																																																																																																																											this.useTurn = true;
																																																																																																																																																																																																																																											this.useAnimation = 17;
																																																																																																																																																																																																																																											this.useTime = 17;
																																																																																																																																																																																																																																											this.maxStack = 30;
																																																																																																																																																																																																																																											this.consumable = true;
																																																																																																																																																																																																																																											this.width = 10;
																																																																																																																																																																																																																																											this.height = 10;
																																																																																																																																																																																																																																											this.buffType = 25;
																																																																																																																																																																																																																																											this.buffTime = 7200;
																																																																																																																																																																																																																																											this.value = 100;
																																																																																																																																																																																																																																										}
																																																																																																																																																																																																																																										else
																																																																																																																																																																																																																																										{
																																																																																																																																																																																																																																											if (this.type == 354)
																																																																																																																																																																																																																																											{
																																																																																																																																																																																																																																												this.name = "Bookcase";
																																																																																																																																																																																																																																												this.useStyle = 1;
																																																																																																																																																																																																																																												this.useTurn = true;
																																																																																																																																																																																																																																												this.useAnimation = 15;
																																																																																																																																																																																																																																												this.useTime = 10;
																																																																																																																																																																																																																																												this.autoReuse = true;
																																																																																																																																																																																																																																												this.maxStack = 99;
																																																																																																																																																																																																																																												this.consumable = true;
																																																																																																																																																																																																																																												this.createTile = 101;
																																																																																																																																																																																																																																												this.width = 20;
																																																																																																																																																																																																																																												this.height = 20;
																																																																																																																																																																																																																																												this.value = 300;
																																																																																																																																																																																																																																											}
																																																																																																																																																																																																																																											else
																																																																																																																																																																																																																																											{
																																																																																																																																																																																																																																												if (this.type == 355)
																																																																																																																																																																																																																																												{
																																																																																																																																																																																																																																													this.name = "Throne";
																																																																																																																																																																																																																																													this.useStyle = 1;
																																																																																																																																																																																																																																													this.useTurn = true;
																																																																																																																																																																																																																																													this.useAnimation = 15;
																																																																																																																																																																																																																																													this.useTime = 10;
																																																																																																																																																																																																																																													this.autoReuse = true;
																																																																																																																																																																																																																																													this.maxStack = 99;
																																																																																																																																																																																																																																													this.consumable = true;
																																																																																																																																																																																																																																													this.createTile = 102;
																																																																																																																																																																																																																																													this.width = 20;
																																																																																																																																																																																																																																													this.height = 20;
																																																																																																																																																																																																																																													this.value = 300;
																																																																																																																																																																																																																																												}
																																																																																																																																																																																																																																												else
																																																																																																																																																																																																																																												{
																																																																																																																																																																																																																																													if (this.type == 356)
																																																																																																																																																																																																																																													{
																																																																																																																																																																																																																																														this.name = "Bowl";
																																																																																																																																																																																																																																														this.useStyle = 1;
																																																																																																																																																																																																																																														this.useTurn = true;
																																																																																																																																																																																																																																														this.useAnimation = 15;
																																																																																																																																																																																																																																														this.useTime = 10;
																																																																																																																																																																																																																																														this.autoReuse = true;
																																																																																																																																																																																																																																														this.maxStack = 99;
																																																																																																																																																																																																																																														this.consumable = true;
																																																																																																																																																																																																																																														this.createTile = 103;
																																																																																																																																																																																																																																														this.width = 16;
																																																																																																																																																																																																																																														this.height = 24;
																																																																																																																																																																																																																																														this.value = 20;
																																																																																																																																																																																																																																													}
																																																																																																																																																																																																																																													else
																																																																																																																																																																																																																																													{
																																																																																																																																																																																																																																														if (this.type == 357)
																																																																																																																																																																																																																																														{
																																																																																																																																																																																																																																															this.name = "Bowl of Soup";
																																																																																																																																																																																																																																															this.useSound = 3;
																																																																																																																																																																																																																																															this.useStyle = 2;
																																																																																																																																																																																																																																															this.useTurn = true;
																																																																																																																																																																																																																																															this.useAnimation = 17;
																																																																																																																																																																																																																																															this.useTime = 17;
																																																																																																																																																																																																																																															this.maxStack = 30;
																																																																																																																																																																																																																																															this.consumable = true;
																																																																																																																																																																																																																																															this.width = 10;
																																																																																																																																																																																																																																															this.height = 10;
																																																																																																																																																																																																																																															this.buffType = 26;
																																																																																																																																																																																																																																															this.buffTime = 36000;
																																																																																																																																																																																																																																															this.rare = 1;
																																																																																																																																																																																																																																															this.toolTip = "Minor improvements to all stats";
																																																																																																																																																																																																																																															this.value = 1000;
																																																																																																																																																																																																																																														}
																																																																																																																																																																																																																																														else
																																																																																																																																																																																																																																														{
																																																																																																																																																																																																																																															if (this.type == 358)
																																																																																																																																																																																																																																															{
																																																																																																																																																																																																																																																this.name = "Toilet";
																																																																																																																																																																																																																																																this.useStyle = 1;
																																																																																																																																																																																																																																																this.useTurn = true;
																																																																																																																																																																																																																																																this.useAnimation = 15;
																																																																																																																																																																																																																																																this.useTime = 10;
																																																																																																																																																																																																																																																this.autoReuse = true;
																																																																																																																																																																																																																																																this.maxStack = 99;
																																																																																																																																																																																																																																																this.consumable = true;
																																																																																																																																																																																																																																																this.createTile = 15;
																																																																																																																																																																																																																																																this.placeStyle = 1;
																																																																																																																																																																																																																																																this.width = 12;
																																																																																																																																																																																																																																																this.height = 30;
																																																																																																																																																																																																																																																this.value = 150;
																																																																																																																																																																																																																																															}
																																																																																																																																																																																																																																															else
																																																																																																																																																																																																																																															{
																																																																																																																																																																																																																																																if (this.type == 359)
																																																																																																																																																																																																																																																{
																																																																																																																																																																																																																																																	this.name = "Grandfather Clock";
																																																																																																																																																																																																																																																	this.useStyle = 1;
																																																																																																																																																																																																																																																	this.useTurn = true;
																																																																																																																																																																																																																																																	this.useAnimation = 15;
																																																																																																																																																																																																																																																	this.useTime = 10;
																																																																																																																																																																																																																																																	this.autoReuse = true;
																																																																																																																																																																																																																																																	this.maxStack = 99;
																																																																																																																																																																																																																																																	this.consumable = true;
																																																																																																																																																																																																																																																	this.createTile = 104;
																																																																																																																																																																																																																																																	this.width = 20;
																																																																																																																																																																																																																																																	this.height = 20;
																																																																																																																																																																																																																																																	this.value = 300;
																																																																																																																																																																																																																																																}
																																																																																																																																																																																																																																																else
																																																																																																																																																																																																																																																{
																																																																																																																																																																																																																																																	if (this.type == 360)
																																																																																																																																																																																																																																																	{
																																																																																																																																																																																																																																																		this.name = "Statue";
																																																																																																																																																																																																																																																		this.useStyle = 1;
																																																																																																																																																																																																																																																		this.useTurn = true;
																																																																																																																																																																																																																																																		this.useAnimation = 15;
																																																																																																																																																																																																																																																		this.useTime = 10;
																																																																																																																																																																																																																																																		this.autoReuse = true;
																																																																																																																																																																																																																																																		this.maxStack = 99;
																																																																																																																																																																																																																																																		this.consumable = true;
																																																																																																																																																																																																																																																		this.createTile = 105;
																																																																																																																																																																																																																																																		this.width = 20;
																																																																																																																																																																																																																																																		this.height = 20;
																																																																																																																																																																																																																																																		this.value = 300;
																																																																																																																																																																																																																																																	}
																																																																																																																																																																																																																																																	else
																																																																																																																																																																																																																																																	{
																																																																																																																																																																																																																																																		if (this.type == 361)
																																																																																																																																																																																																																																																		{
																																																																																																																																																																																																																																																			this.useStyle = 4;
																																																																																																																																																																																																																																																			this.consumable = true;
																																																																																																																																																																																																																																																			this.useAnimation = 45;
																																																																																																																																																																																																																																																			this.useTime = 45;
																																																																																																																																																																																																																																																			this.name = "Goblin Battle Standard";
																																																																																																																																																																																																																																																			this.width = 28;
																																																																																																																																																																																																																																																			this.height = 28;
																																																																																																																																																																																																																																																			this.toolTip = "Summons a Goblin Army";
																																																																																																																																																																																																																																																		}
																																																																																																																																																																																																																																																		else
																																																																																																																																																																																																																																																		{
																																																																																																																																																																																																																																																			if (this.type == 362)
																																																																																																																																																																																																																																																			{
																																																																																																																																																																																																																																																				this.name = "Tattered Cloth";
																																																																																																																																																																																																																																																				this.maxStack = 99;
																																																																																																																																																																																																																																																				this.width = 28;
																																																																																																																																																																																																																																																				this.height = 28;
																																																																																																																																																																																																																																																				this.value = 30;
																																																																																																																																																																																																																																																			}
																																																																																																																																																																																																																																																			else
																																																																																																																																																																																																																																																			{
																																																																																																																																																																																																																																																				if (this.type == 363)
																																																																																																																																																																																																																																																				{
																																																																																																																																																																																																																																																					this.name = "Sawmill";
																																																																																																																																																																																																																																																					this.useStyle = 1;
																																																																																																																																																																																																																																																					this.useTurn = true;
																																																																																																																																																																																																																																																					this.useAnimation = 15;
																																																																																																																																																																																																																																																					this.useTime = 10;
																																																																																																																																																																																																																																																					this.autoReuse = true;
																																																																																																																																																																																																																																																					this.maxStack = 99;
																																																																																																																																																																																																																																																					this.consumable = true;
																																																																																																																																																																																																																																																					this.createTile = 106;
																																																																																																																																																																																																																																																					this.width = 20;
																																																																																																																																																																																																																																																					this.height = 20;
																																																																																																																																																																																																																																																					this.value = 300;
																																																																																																																																																																																																																																																					this.toolTip = "Used for advanced wood crafting";
																																																																																																																																																																																																																																																				}
																																																																																																																																																																																																																																																			}
																																																																																																																																																																																																																																																		}
																																																																																																																																																																																																																																																	}
																																																																																																																																																																																																																																																}
																																																																																																																																																																																																																																															}
																																																																																																																																																																																																																																														}
																																																																																																																																																																																																																																													}
																																																																																																																																																																																																																																												}
																																																																																																																																																																																																																																											}
																																																																																																																																																																																																																																										}
																																																																																																																																																																																																																																									}
																																																																																																																																																																																																																																								}
																																																																																																																																																																																																																																							}
																																																																																																																																																																																																																																						}
																																																																																																																																																																																																																																					}
																																																																																																																																																																																																																																				}
																																																																																																																																																																																																																																			}
																																																																																																																																																																																																																																		}
																																																																																																																																																																																																																																	}
																																																																																																																																																																																																																																}
																																																																																																																																																																																																																															}
																																																																																																																																																																																																																														}
																																																																																																																																																																																																																													}
																																																																																																																																																																																																																												}
																																																																																																																																																																																																																											}
																																																																																																																																																																																																																										}
																																																																																																																																																																																																																									}
																																																																																																																																																																																																																								}
																																																																																																																																																																																																																							}
																																																																																																																																																																																																																						}
																																																																																																																																																																																																																					}
																																																																																																																																																																																																																				}
																																																																																																																																																																																																																			}
																																																																																																																																																																																																																		}
																																																																																																																																																																																																																	}
																																																																																																																																																																																																																}
																																																																																																																																																																																																															}
																																																																																																																																																																																																														}
																																																																																																																																																																																																													}
																																																																																																																																																																																																												}
																																																																																																																																																																																																											}
																																																																																																																																																																																																										}
																																																																																																																																																																																																									}
																																																																																																																																																																																																								}
																																																																																																																																																																																																							}
																																																																																																																																																																																																						}
																																																																																																																																																																																																					}
																																																																																																																																																																																																				}
																																																																																																																																																																																																			}
																																																																																																																																																																																																		}
																																																																																																																																																																																																	}
																																																																																																																																																																																																}
																																																																																																																																																																																															}
																																																																																																																																																																																														}
																																																																																																																																																																																													}
																																																																																																																																																																																												}
																																																																																																																																																																																											}
																																																																																																																																																																																										}
																																																																																																																																																																																									}
																																																																																																																																																																																								}
																																																																																																																																																																																							}
																																																																																																																																																																																						}
																																																																																																																																																																																					}
																																																																																																																																																																																				}
																																																																																																																																																																																			}
																																																																																																																																																																																		}
																																																																																																																																																																																	}
																																																																																																																																																																																}
																																																																																																																																																																															}
																																																																																																																																																																														}
																																																																																																																																																																													}
																																																																																																																																																																												}
																																																																																																																																																																											}
																																																																																																																																																																										}
																																																																																																																																																																									}
																																																																																																																																																																								}
																																																																																																																																																																							}
																																																																																																																																																																						}
																																																																																																																																																																					}
																																																																																																																																																																				}
																																																																																																																																																																			}
																																																																																																																																																																		}
																																																																																																																																																																	}
																																																																																																																																																																}
																																																																																																																																																															}
																																																																																																																																																														}
																																																																																																																																																													}
																																																																																																																																																												}
																																																																																																																																																											}
																																																																																																																																																										}
																																																																																																																																																									}
																																																																																																																																																								}
																																																																																																																																																							}
																																																																																																																																																						}
																																																																																																																																																					}
																																																																																																																																																				}
																																																																																																																																																			}
																																																																																																																																																		}
																																																																																																																																																	}
																																																																																																																																																}
																																																																																																																																															}
																																																																																																																																														}
																																																																																																																																													}
																																																																																																																																												}
																																																																																																																																											}
																																																																																																																																										}
																																																																																																																																									}
																																																																																																																																								}
																																																																																																																																							}
																																																																																																																																						}
																																																																																																																																					}
																																																																																																																																				}
																																																																																																																																			}
																																																																																																																																		}
																																																																																																																																	}
																																																																																																																																}
																																																																																																																															}
																																																																																																																														}
																																																																																																																													}
																																																																																																																												}
																																																																																																																											}
																																																																																																																										}
																																																																																																																									}
																																																																																																																								}
																																																																																																																							}
																																																																																																																						}
																																																																																																																					}
																																																																																																																				}
																																																																																																																			}
																																																																																																																		}
																																																																																																																	}
																																																																																																																}
																																																																																																															}
																																																																																																														}
																																																																																																													}
																																																																																																												}
																																																																																																											}
																																																																																																										}
																																																																																																									}
																																																																																																								}
																																																																																																							}
																																																																																																						}
																																																																																																					}
																																																																																																				}
																																																																																																			}
																																																																																																		}
																																																																																																	}
																																																																																																}
																																																																																															}
																																																																																														}
																																																																																													}
																																																																																												}
																																																																																											}
																																																																																										}
																																																																																									}
																																																																																								}
																																																																																							}
																																																																																						}
																																																																																					}
																																																																																				}
																																																																																			}
																																																																																		}
																																																																																	}
																																																																																}
																																																																															}
																																																																														}
																																																																													}
																																																																												}
																																																																											}
																																																																										}
																																																																									}
																																																																								}
																																																																							}
																																																																						}
																																																																					}
																																																																				}
																																																																			}
																																																																		}
																																																																	}
																																																																}
																																																															}
																																																														}
																																																													}
																																																												}
																																																											}
																																																										}
																																																									}
																																																								}
																																																							}
																																																						}
																																																					}
																																																				}
																																																			}
																																																		}
																																																	}
																																																}
																																															}
																																														}
																																													}
																																												}
																																											}
																																										}
																																									}
																																								}
																																							}
																																						}
																																					}
																																				}
																																			}
																																		}
																																	}
																																}
																															}
																														}
																													}
																												}
																											}
																										}
																									}
																								}
																							}
																						}
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			if (!noMatCheck)
			{
				this.checkMat();
			}
		}
		public static string VersionName(string oldName, int release)
		{
			string result = oldName;
			if (release <= 4)
			{
				if (oldName == "Cobalt Helmet")
				{
					result = "Jungle Hat";
				}
				else
				{
					if (oldName == "Cobalt Breastplate")
					{
						result = "Jungle Shirt";
					}
					else
					{
						if (oldName == "Cobalt Greaves")
						{
							result = "Jungle Pants";
						}
					}
				}
			}
			if (release <= 13 && oldName == "Jungle Rose")
			{
				result = "Jungle Spores";
			}
			if (release <= 20)
			{
				if (oldName == "Gills potion")
				{
					result = "Gills Potion";
				}
				else
				{
					if (oldName == "Thorn Chakrum")
					{
						result = "Thorn Chakram";
					}
					else
					{
						if (oldName == "Ball 'O Hurt")
						{
							result = "Ball O' Hurt";
						}
					}
				}
			}
			return result;
		}
		public Color GetAlpha(Color newColor)
		{
			int r = (int)newColor.R - this.alpha;
			int g = (int)newColor.G - this.alpha;
			int b = (int)newColor.B - this.alpha;
			int num = (int)newColor.A - this.alpha;
			if (num < 0)
			{
				num = 0;
			}
			if (num > 255)
			{
				num = 255;
			}
			if (this.type >= 198 && this.type <= 203)
			{
				return Color.White;
			}
			return new Color(r, g, b, num);
		}
		public Color GetColor(Color newColor)
		{
			int num = (int)(this.color.R - (255 - newColor.R));
			int num2 = (int)(this.color.G - (255 - newColor.G));
			int num3 = (int)(this.color.B - (255 - newColor.B));
			int num4 = (int)(this.color.A - (255 - newColor.A));
			if (num < 0)
			{
				num = 0;
			}
			if (num > 255)
			{
				num = 255;
			}
			if (num2 < 0)
			{
				num2 = 0;
			}
			if (num2 > 255)
			{
				num2 = 255;
			}
			if (num3 < 0)
			{
				num3 = 0;
			}
			if (num3 > 255)
			{
				num3 = 255;
			}
			if (num4 < 0)
			{
				num4 = 0;
			}
			if (num4 > 255)
			{
				num4 = 255;
			}
			return new Color(num, num2, num3, num4);
		}
		public void UpdateItem(int i)
		{
			if (this.active)
			{
				if (Main.netMode == 0)
				{
					this.owner = Main.myPlayer;
				}
				float num = 0.1f;
				float num2 = 7f;
				if (this.wet)
				{
					num2 = 5f;
					num = 0.08f;
				}
				Vector2 value = this.velocity * 0.5f;
				if (this.ownTime > 0)
				{
					this.ownTime--;
				}
				else
				{
					this.ownIgnore = -1;
				}
				if (this.keepTime > 0)
				{
					this.keepTime--;
				}
				if (!this.beingGrabbed)
				{
					this.velocity.Y = this.velocity.Y + num;
					if (this.velocity.Y > num2)
					{
						this.velocity.Y = num2;
					}
					this.velocity.X = this.velocity.X * 0.95f;
					if ((double)this.velocity.X < 0.1 && (double)this.velocity.X > -0.1)
					{
						this.velocity.X = 0f;
					}
					bool flag = Collision.LavaCollision(this.position, this.width, this.height);
					if (flag)
					{
						this.lavaWet = true;
					}
					bool flag2 = Collision.WetCollision(this.position, this.width, this.height);
					if (flag2)
					{
						if (!this.wet)
						{
							if (this.wetCount == 0)
							{
								this.wetCount = 20;
								if (!flag)
								{
									for (int j = 0; j < 10; j++)
									{
										int num3 = Dust.NewDust(new Vector2(this.position.X - 6f, this.position.Y + (float)(this.height / 2) - 8f), this.width + 12, 24, 33, 0f, 0f, 0, default(Color), 1f);
										Dust expr_1EC_cp_0 = Main.dust[num3];
										expr_1EC_cp_0.velocity.Y = expr_1EC_cp_0.velocity.Y - 4f;
										Dust expr_20A_cp_0 = Main.dust[num3];
										expr_20A_cp_0.velocity.X = expr_20A_cp_0.velocity.X * 2.5f;
										Main.dust[num3].scale = 1.3f;
										Main.dust[num3].alpha = 100;
										Main.dust[num3].noGravity = true;
									}
									Main.PlaySound(19, (int)this.position.X, (int)this.position.Y, 1);
								}
								else
								{
									for (int k = 0; k < 5; k++)
									{
										int num4 = Dust.NewDust(new Vector2(this.position.X - 6f, this.position.Y + (float)(this.height / 2) - 8f), this.width + 12, 24, 35, 0f, 0f, 0, default(Color), 1f);
										Dust expr_2F2_cp_0 = Main.dust[num4];
										expr_2F2_cp_0.velocity.Y = expr_2F2_cp_0.velocity.Y - 1.5f;
										Dust expr_310_cp_0 = Main.dust[num4];
										expr_310_cp_0.velocity.X = expr_310_cp_0.velocity.X * 2.5f;
										Main.dust[num4].scale = 1.3f;
										Main.dust[num4].alpha = 100;
										Main.dust[num4].noGravity = true;
									}
									Main.PlaySound(19, (int)this.position.X, (int)this.position.Y, 1);
								}
							}
							this.wet = true;
						}
					}
					else
					{
						if (this.wet)
						{
							this.wet = false;
						}
					}
					if (!this.wet)
					{
						this.lavaWet = false;
					}
					if (this.wetCount > 0)
					{
						this.wetCount -= 1;
					}
					if (this.wet)
					{
						if (this.wet)
						{
							Vector2 vector = this.velocity;
							this.velocity = Collision.TileCollision(this.position, this.velocity, this.width, this.height, false, false);
							if (this.velocity.X != vector.X)
							{
								value.X = this.velocity.X;
							}
							if (this.velocity.Y != vector.Y)
							{
								value.Y = this.velocity.Y;
							}
						}
					}
					else
					{
						this.velocity = Collision.TileCollision(this.position, this.velocity, this.width, this.height, false, false);
					}
					if (this.owner == Main.myPlayer && this.lavaWet && this.type != 312 && this.type != 318 && this.type != 173 && this.type != 174 && this.type != 175 && this.rare == 0)
					{
						if (this.type == 267 && Main.netMode != 1)
						{
							for (int l = 0; l < 1000; l++)
							{
								if (Main.npc[l].active && Main.npc[l].type == 22)
								{
									if (Main.netMode == 2)
									{
										NetMessage.SendData(28, -1, -1, "", l, 9999f, 10f, (float)(-(float)Main.npc[l].direction), 0);
									}
									Main.npc[l].StrikeNPC(9999, 10f, -Main.npc[l].direction, false);
								}
							}
						}
						this.active = false;
						this.type = 0;
						this.name = "";
						this.stack = 0;
						if (Main.netMode != 0)
						{
							NetMessage.SendData(21, -1, -1, "", i, 0f, 0f, 0f, 0);
						}
					}
					if (this.type == 75 && Main.dayTime)
					{
						for (int m = 0; m < 10; m++)
						{
							Dust.NewDust(this.position, this.width, this.height, 15, this.velocity.X, this.velocity.Y, 150, default(Color), 1.2f);
						}
						for (int n = 0; n < 3; n++)
						{
							Gore.NewGore(this.position, new Vector2(this.velocity.X, this.velocity.Y), Main.rand.Next(16, 18), 1f);
						}
						this.active = false;
						this.type = 0;
						this.stack = 0;
						if (Main.netMode == 2)
						{
							NetMessage.SendData(21, -1, -1, "", i, 0f, 0f, 0f, 0);
						}
					}
				}
				else
				{
					this.beingGrabbed = false;
				}
				if (this.type == 8 || this.type == 41 || this.type == 75 || this.type == 105 || this.type == 116)
				{
					if (!this.wet)
					{
						Lighting.addLight((int)((this.position.X - 7f) / 16f), (int)((this.position.Y - 7f) / 16f), 1f);
					}
				}
				else
				{
					if (this.type == 282 || this.type == 286)
					{
						Lighting.addLight((int)((this.position.X - 7f) / 16f), (int)((this.position.Y - 7f) / 16f), 1f);
					}
					else
					{
						if (this.type == 331)
						{
							Lighting.addLight((int)((this.position.X - 7f) / 16f), (int)((this.position.Y - 7f) / 16f), 0.8f);
						}
						else
						{
							if (this.type == 183)
							{
								Lighting.addLight((int)((this.position.X - 7f) / 16f), (int)((this.position.Y - 7f) / 16f), 0.5f);
							}
						}
					}
				}
				if (this.type == 75)
				{
					if (Main.rand.Next(25) == 0)
					{
						Dust.NewDust(this.position, this.width, this.height, 15, this.velocity.X * 0.5f, this.velocity.Y * 0.5f, 150, default(Color), 1.2f);
					}
					if (Main.rand.Next(50) == 0)
					{
						Gore.NewGore(this.position, new Vector2(this.velocity.X * 0.2f, this.velocity.Y * 0.2f), Main.rand.Next(16, 18), 1f);
					}
				}
				if (this.spawnTime < 2147483646)
				{
					this.spawnTime++;
				}
				if (Main.netMode == 2 && this.owner != Main.myPlayer)
				{
					this.release++;
					if (this.release >= 300)
					{
						this.release = 0;
						NetMessage.SendData(39, this.owner, -1, "", i, 0f, 0f, 0f, 0);
					}
				}
				if (this.wet)
				{
					this.position += value;
				}
				else
				{
					this.position += this.velocity;
				}
				if (this.noGrabDelay > 0)
				{
					this.noGrabDelay--;
				}
			}
		}
		public static int NewItem(int X, int Y, int Width, int Height, int Type, int Stack = 1, bool noBroadcast = false)
		{
			if (WorldGen.gen)
			{
				return 0;
			}
			int num = 200;
			Main.item[200] = new Item();
			if (Main.netMode != 1)
			{
				for (int i = 0; i < 200; i++)
				{
					if (!Main.item[i].active)
					{
						num = i;
						break;
					}
				}
			}
			if (num == 200 && Main.netMode != 1)
			{
				int num2 = 0;
				for (int j = 0; j < 200; j++)
				{
					if (Main.item[j].spawnTime > num2)
					{
						num2 = Main.item[j].spawnTime;
						num = j;
					}
				}
			}
			Main.item[num] = new Item();
			Main.item[num].SetDefaults(Type, false);
			Main.item[num].position.X = (float)(X + Width / 2 - Main.item[num].width / 2);
			Main.item[num].position.Y = (float)(Y + Height / 2 - Main.item[num].height / 2);
			Main.item[num].wet = Collision.WetCollision(Main.item[num].position, Main.item[num].width, Main.item[num].height);
			Main.item[num].velocity.X = (float)Main.rand.Next(-30, 31) * 0.1f;
			Main.item[num].velocity.Y = (float)Main.rand.Next(-40, -15) * 0.1f;
			Main.item[num].active = true;
			Main.item[num].spawnTime = 0;
			Main.item[num].stack = Stack;
			if (Main.netMode == 2 && !noBroadcast)
			{
				NetMessage.SendData(21, -1, -1, "", num, 0f, 0f, 0f, 0);
				Main.item[num].FindOwner(num);
			}
			else
			{
				if (Main.netMode == 0)
				{
					Main.item[num].owner = Main.myPlayer;
				}
			}
			return num;
		}
		public void FindOwner(int whoAmI)
		{
			if (this.keepTime > 0)
			{
				return;
			}
			int num = this.owner;
			this.owner = 255;
			float num2 = -1f;
			for (int i = 0; i < 255; i++)
			{
				if (this.ownIgnore != i && Main.player[i].active && Main.player[i].ItemSpace(Main.item[whoAmI]))
				{
					float num3 = Math.Abs(Main.player[i].position.X + (float)(Main.player[i].width / 2) - this.position.X - (float)(this.width / 2)) + Math.Abs(Main.player[i].position.Y + (float)(Main.player[i].height / 2) - this.position.Y - (float)this.height);
					if (num3 < (float)(Main.screenWidth / 2 + Main.screenHeight / 2) && (num2 == -1f || num3 < num2))
					{
						num2 = num3;
						this.owner = i;
					}
				}
			}
			if (this.owner != num && ((num == Main.myPlayer && Main.netMode == 1) || (num == 255 && Main.netMode == 2) || !Main.player[num].active))
			{
				NetMessage.SendData(21, -1, -1, "", whoAmI, 0f, 0f, 0f, 0);
				if (this.active)
				{
					NetMessage.SendData(22, -1, -1, "", whoAmI, 0f, 0f, 0f, 0);
				}
			}
		}
		public object Clone()
		{
			return base.MemberwiseClone();
		}
		public bool IsTheSameAs(Item compareItem)
		{
			return this.name == compareItem.name;
		}
		public bool IsNotTheSameAs(Item compareItem)
		{
			return this.name != compareItem.name || this.stack != compareItem.stack;
		}
	}
}
