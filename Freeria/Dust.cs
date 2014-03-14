using Microsoft.Xna.Framework;
using System;
namespace Freeria
{
	public class Dust
	{
		public Vector2 position;
		public Vector2 velocity;
		public static int lavaBubbles;
		public float fadeIn;
		public bool noGravity;
		public float scale;
		public float rotation;
		public bool noLight;
		public bool active;
		public int type;
		public Color color;
		public int alpha;
		public Rectangle frame;
		public static int NewDust(Vector2 Position, int Width, int Height, int Type, float SpeedX = 0f, float SpeedY = 0f, int Alpha = 0, Color newColor = default(Color), float Scale = 1f)
		{
			if (Main.gamePaused)
			{
				return 0;
			}
			if (WorldGen.gen)
			{
				return 0;
			}
			if (Main.netMode == 2)
			{
				return 0;
			}
			Rectangle rectangle = new Rectangle((int)(Main.player[Main.myPlayer].position.X - (float)(Main.screenWidth / 2) - 100f), (int)(Main.player[Main.myPlayer].position.Y - (float)(Main.screenHeight / 2) - 100f), Main.screenWidth + 200, Main.screenHeight + 200);
			Rectangle value = new Rectangle((int)Position.X, (int)Position.Y, 10, 10);
			if (!rectangle.Intersects(value))
			{
				return 1000;
			}
			int result = 1000;
			int i = 0;
			while (i < 1000)
			{
				if (!Main.dust[i].active)
				{
					int num = Width;
					int num2 = Height;
					if (num < 5)
					{
						num = 5;
					}
					if (num2 < 5)
					{
						num2 = 5;
					}
					result = i;
					Main.dust[i].fadeIn = 0f;
					Main.dust[i].active = true;
					Main.dust[i].type = Type;
					Main.dust[i].noGravity = false;
					Main.dust[i].color = newColor;
					Main.dust[i].alpha = Alpha;
					Main.dust[i].position.X = Position.X + (float)Main.rand.Next(num - 4) + 4f;
					Main.dust[i].position.Y = Position.Y + (float)Main.rand.Next(num2 - 4) + 4f;
					Main.dust[i].velocity.X = (float)Main.rand.Next(-20, 21) * 0.1f + SpeedX;
					Main.dust[i].velocity.Y = (float)Main.rand.Next(-20, 21) * 0.1f + SpeedY;
					Main.dust[i].frame.X = 10 * Type;
					Main.dust[i].frame.Y = 10 * Main.rand.Next(3);
					Main.dust[i].frame.Width = 8;
					Main.dust[i].frame.Height = 8;
					Main.dust[i].rotation = 0f;
					Main.dust[i].scale = 1f + (float)Main.rand.Next(-20, 21) * 0.01f;
					Main.dust[i].scale *= Scale;
					Main.dust[i].noLight = false;
					if (Main.dust[i].type == 6 || Main.dust[i].type == 29)
					{
						Main.dust[i].velocity.Y = (float)Main.rand.Next(-10, 6) * 0.1f;
						Dust expr_2E8_cp_0 = Main.dust[i];
						expr_2E8_cp_0.velocity.X = expr_2E8_cp_0.velocity.X * 0.3f;
						Main.dust[i].scale *= 0.7f;
					}
					if (Main.dust[i].type == 33)
					{
						Main.dust[i].alpha = 170;
						Dust expr_339 = Main.dust[i];
						expr_339.velocity *= 0.5f;
						Dust expr_35A_cp_0 = Main.dust[i];
						expr_35A_cp_0.velocity.Y = expr_35A_cp_0.velocity.Y + 1f;
					}
					if (Main.dust[i].type == 41)
					{
						Dust expr_382 = Main.dust[i];
						expr_382.velocity *= 0f;
					}
					if (Main.dust[i].type != 34 && Main.dust[i].type != 35)
					{
						break;
					}
					Dust expr_3C1 = Main.dust[i];
					expr_3C1.velocity *= 0.1f;
					Main.dust[i].velocity.Y = -0.5f;
					if (Main.dust[i].type == 34 && !Collision.WetCollision(new Vector2(Main.dust[i].position.X, Main.dust[i].position.Y - 8f), 4, 4))
					{
						Main.dust[i].active = false;
						break;
					}
					break;
				}
				else
				{
					i++;
				}
			}
			return result;
		}
		public static void UpdateDust()
		{
			Dust.lavaBubbles = 0;
			for (int i = 0; i < 1000; i++)
			{
				if (i < Main.numDust)
				{
					if (Main.dust[i].active)
					{
						if (Main.dust[i].type == 35)
						{
							Dust.lavaBubbles++;
						}
						Dust expr_4C = Main.dust[i];
						expr_4C.position += Main.dust[i].velocity;
						if (Main.dust[i].type == 6 || Main.dust[i].type == 29)
						{
							if (!Main.dust[i].noGravity)
							{
								Dust expr_A4_cp_0 = Main.dust[i];
								expr_A4_cp_0.velocity.Y = expr_A4_cp_0.velocity.Y + 0.05f;
							}
							if (!Main.dust[i].noLight)
							{
								float num = Main.dust[i].scale * 1.6f;
								if (Main.dust[i].type == 29)
								{
									num *= 0.2f;
								}
								if (num > 1f)
								{
									num = 1f;
								}
								Lighting.addLight((int)(Main.dust[i].position.X / 16f), (int)(Main.dust[i].position.Y / 16f), num);
							}
						}
						else
						{
							if (Main.dust[i].type == 14 || Main.dust[i].type == 16 || Main.dust[i].type == 31 || Main.dust[i].type == 46)
							{
								Dust expr_186_cp_0 = Main.dust[i];
								expr_186_cp_0.velocity.Y = expr_186_cp_0.velocity.Y * 0.98f;
								Dust expr_1A3_cp_0 = Main.dust[i];
								expr_1A3_cp_0.velocity.X = expr_1A3_cp_0.velocity.X * 0.98f;
							}
							else
							{
								if (Main.dust[i].type == 32)
								{
									Main.dust[i].scale -= 0.01f;
									Dust expr_1ED_cp_0 = Main.dust[i];
									expr_1ED_cp_0.velocity.X = expr_1ED_cp_0.velocity.X * 0.96f;
									Dust expr_20A_cp_0 = Main.dust[i];
									expr_20A_cp_0.velocity.Y = expr_20A_cp_0.velocity.Y + 0.1f;
								}
								else
								{
									if (Main.dust[i].type == 43)
									{
										Main.dust[i].rotation += 0.1f * Main.dust[i].scale;
										float num2 = (float)Lighting.GetColor((int)(Main.dust[i].position.X / 16f), (int)(Main.dust[i].position.Y / 16f)).R;
										num2 = num2 / 256f * Main.dust[i].scale * 1.09f;
										if (num2 > 1f)
										{
											num2 = 1f;
										}
										if (Main.dust[i].alpha < 255)
										{
											Main.dust[i].scale += 0.09f;
											if (Main.dust[i].scale >= 1f)
											{
												Main.dust[i].scale = 1f;
												Main.dust[i].alpha = 255;
											}
										}
										else
										{
											if ((double)Main.dust[i].scale < 0.8)
											{
												Main.dust[i].scale -= 0.01f;
											}
											if ((double)Main.dust[i].scale < 0.5)
											{
												Main.dust[i].scale -= 0.01f;
											}
										}
										if (num2 == 0f)
										{
											Main.dust[i].active = false;
										}
										else
										{
											Lighting.addLight((int)(Main.dust[i].position.X / 16f), (int)(Main.dust[i].position.Y / 16f), num2);
										}
									}
									else
									{
										if (Main.dust[i].type == 15)
										{
											Dust expr_3FA_cp_0 = Main.dust[i];
											expr_3FA_cp_0.velocity.Y = expr_3FA_cp_0.velocity.Y * 0.98f;
											Dust expr_417_cp_0 = Main.dust[i];
											expr_417_cp_0.velocity.X = expr_417_cp_0.velocity.X * 0.98f;
											float num3 = Main.dust[i].scale;
											if (Main.dust[i].noLight)
											{
												num3 = 0f;
												Main.dust[i].scale -= 0.1f;
											}
											if (num3 > 1f)
											{
												num3 = 1f;
											}
											if (Main.dust[i].noLight)
											{
												num3 *= 0.5f;
											}
											Lighting.addLight((int)(Main.dust[i].position.X / 16f), (int)(Main.dust[i].position.Y / 16f), num3);
										}
										else
										{
											if (Main.dust[i].type == 20 || Main.dust[i].type == 21)
											{
												Main.dust[i].scale += 0.005f;
												Dust expr_507_cp_0 = Main.dust[i];
												expr_507_cp_0.velocity.Y = expr_507_cp_0.velocity.Y * 0.94f;
												Dust expr_524_cp_0 = Main.dust[i];
												expr_524_cp_0.velocity.X = expr_524_cp_0.velocity.X * 0.94f;
												float num4 = Main.dust[i].scale * 0.8f;
												if (Main.dust[i].type == 21)
												{
													num4 = Main.dust[i].scale * 0.4f;
												}
												if (num4 > 1f)
												{
													num4 = 1f;
												}
												Lighting.addLight((int)(Main.dust[i].position.X / 16f), (int)(Main.dust[i].position.Y / 16f), num4);
											}
											else
											{
												if (Main.dust[i].type == 27 || Main.dust[i].type == 45)
												{
													Dust expr_5E3 = Main.dust[i];
													expr_5E3.velocity *= 0.94f;
													Main.dust[i].scale += 0.002f;
													float num5 = Main.dust[i].scale;
													if (Main.dust[i].noLight)
													{
														num5 *= 0.1f;
														Main.dust[i].scale -= 0.06f;
														if (Main.dust[i].scale < 1f)
														{
															Main.dust[i].scale -= 0.06f;
														}
														if (Main.player[Main.myPlayer].wet)
														{
															Dust expr_695 = Main.dust[i];
															expr_695.position += Main.player[Main.myPlayer].velocity * 0.5f;
														}
														else
														{
															Dust expr_6C8 = Main.dust[i];
															expr_6C8.position += Main.player[Main.myPlayer].velocity;
														}
													}
													if (num5 > 1f)
													{
														num5 = 1f;
													}
													Lighting.addLight((int)(Main.dust[i].position.X / 16f), (int)(Main.dust[i].position.Y / 16f), num5);
												}
												else
												{
													if (!Main.dust[i].noGravity && Main.dust[i].type != 41 && Main.dust[i].type != 44)
													{
														Dust expr_76B_cp_0 = Main.dust[i];
														expr_76B_cp_0.velocity.Y = expr_76B_cp_0.velocity.Y + 0.1f;
													}
												}
											}
										}
									}
								}
							}
						}
						if (Main.dust[i].type == 5 && Main.dust[i].noGravity)
						{
							Main.dust[i].scale -= 0.04f;
						}
						if (Main.dust[i].type == 33)
						{
							bool flag = Collision.WetCollision(new Vector2(Main.dust[i].position.X, Main.dust[i].position.Y), 4, 4);
							if (flag)
							{
								Main.dust[i].alpha += 20;
								Main.dust[i].scale -= 0.1f;
							}
							Main.dust[i].alpha += 2;
							Main.dust[i].scale -= 0.005f;
							if (Main.dust[i].alpha > 255)
							{
								Main.dust[i].scale = 0f;
							}
							Dust expr_881_cp_0 = Main.dust[i];
							expr_881_cp_0.velocity.X = expr_881_cp_0.velocity.X * 0.93f;
							if (Main.dust[i].velocity.Y > 4f)
							{
								Main.dust[i].velocity.Y = 4f;
							}
							if (Main.dust[i].noGravity)
							{
								if (Main.dust[i].velocity.X < 0f)
								{
									Main.dust[i].rotation -= 0.2f;
								}
								else
								{
									Main.dust[i].rotation += 0.2f;
								}
								Main.dust[i].scale += 0.03f;
								Dust expr_93F_cp_0 = Main.dust[i];
								expr_93F_cp_0.velocity.X = expr_93F_cp_0.velocity.X * 1.05f;
								Dust expr_95C_cp_0 = Main.dust[i];
								expr_95C_cp_0.velocity.Y = expr_95C_cp_0.velocity.Y + 0.15f;
							}
						}
						if (Main.dust[i].type == 35 && Main.dust[i].noGravity)
						{
							Main.dust[i].scale += 0.03f;
							if (Main.dust[i].scale < 1f)
							{
								Dust expr_9C8_cp_0 = Main.dust[i];
								expr_9C8_cp_0.velocity.Y = expr_9C8_cp_0.velocity.Y + 0.075f;
							}
							Dust expr_9E5_cp_0 = Main.dust[i];
							expr_9E5_cp_0.velocity.X = expr_9E5_cp_0.velocity.X * 1.08f;
							if (Main.dust[i].velocity.X > 0f)
							{
								Main.dust[i].rotation += 0.01f;
							}
							else
							{
								Main.dust[i].rotation -= 0.01f;
							}
						}
						else
						{
							if (Main.dust[i].type == 34 || Main.dust[i].type == 35)
							{
								if (!Collision.WetCollision(new Vector2(Main.dust[i].position.X, Main.dust[i].position.Y - 8f), 4, 4))
								{
									Main.dust[i].scale = 0f;
								}
								else
								{
									Main.dust[i].alpha += Main.rand.Next(2);
									if (Main.dust[i].alpha > 255)
									{
										Main.dust[i].scale = 0f;
									}
									Main.dust[i].velocity.Y = -0.5f;
									if (Main.dust[i].type == 34)
									{
										Main.dust[i].scale += 0.005f;
									}
									else
									{
										Main.dust[i].alpha++;
										Main.dust[i].scale -= 0.01f;
										Main.dust[i].velocity.Y = -0.2f;
									}
									Dust expr_B8B_cp_0 = Main.dust[i];
									expr_B8B_cp_0.velocity.X = expr_B8B_cp_0.velocity.X + (float)Main.rand.Next(-10, 10) * 0.002f;
									if ((double)Main.dust[i].velocity.X < -0.25)
									{
										Main.dust[i].velocity.X = -0.25f;
									}
									if ((double)Main.dust[i].velocity.X > 0.25)
									{
										Main.dust[i].velocity.X = 0.25f;
									}
								}
								if (Main.dust[i].type == 35)
								{
									float num6 = Main.dust[i].scale * 0.2f + 0.5f;
									if (num6 > 1f)
									{
										num6 = 1f;
									}
									Lighting.addLight((int)(Main.dust[i].position.X / 16f), (int)(Main.dust[i].position.Y / 16f), num6);
								}
							}
						}
						if (Main.dust[i].type == 41)
						{
							Dust expr_CA2_cp_0 = Main.dust[i];
							expr_CA2_cp_0.velocity.X = expr_CA2_cp_0.velocity.X + (float)Main.rand.Next(-10, 11) * 0.01f;
							Dust expr_CCF_cp_0 = Main.dust[i];
							expr_CCF_cp_0.velocity.Y = expr_CCF_cp_0.velocity.Y + (float)Main.rand.Next(-10, 11) * 0.01f;
							if ((double)Main.dust[i].velocity.X > 0.75)
							{
								Main.dust[i].velocity.X = 0.75f;
							}
							if ((double)Main.dust[i].velocity.X < -0.75)
							{
								Main.dust[i].velocity.X = -0.75f;
							}
							if ((double)Main.dust[i].velocity.Y > 0.75)
							{
								Main.dust[i].velocity.Y = 0.75f;
							}
							if ((double)Main.dust[i].velocity.Y < -0.75)
							{
								Main.dust[i].velocity.Y = -0.75f;
							}
							Main.dust[i].scale += 0.007f;
							float num7 = Main.dust[i].scale * 0.7f;
							if (num7 > 1f)
							{
								num7 = 1f;
							}
							Lighting.addLight((int)(Main.dust[i].position.X / 16f), (int)(Main.dust[i].position.Y / 16f), num7);
						}
						else
						{
							if (Main.dust[i].type == 44)
							{
								Dust expr_E53_cp_0 = Main.dust[i];
								expr_E53_cp_0.velocity.X = expr_E53_cp_0.velocity.X + (float)Main.rand.Next(-10, 11) * 0.003f;
								Dust expr_E80_cp_0 = Main.dust[i];
								expr_E80_cp_0.velocity.Y = expr_E80_cp_0.velocity.Y + (float)Main.rand.Next(-10, 11) * 0.003f;
								if ((double)Main.dust[i].velocity.X > 0.35)
								{
									Main.dust[i].velocity.X = 0.35f;
								}
								if ((double)Main.dust[i].velocity.X < -0.35)
								{
									Main.dust[i].velocity.X = -0.35f;
								}
								if ((double)Main.dust[i].velocity.Y > 0.35)
								{
									Main.dust[i].velocity.Y = 0.35f;
								}
								if ((double)Main.dust[i].velocity.Y < -0.35)
								{
									Main.dust[i].velocity.Y = -0.35f;
								}
								Main.dust[i].scale += 0.0085f;
								float num8 = Main.dust[i].scale * 0.7f;
								if (num8 > 1f)
								{
									num8 = 1f;
								}
								Lighting.addLight((int)(Main.dust[i].position.X / 16f), (int)(Main.dust[i].position.Y / 16f), num8);
							}
							else
							{
								Dust expr_FEE_cp_0 = Main.dust[i];
								expr_FEE_cp_0.velocity.X = expr_FEE_cp_0.velocity.X * 0.99f;
							}
						}
						Main.dust[i].rotation += Main.dust[i].velocity.X * 0.5f;
						if (Main.dust[i].fadeIn > 0f)
						{
							if (Main.dust[i].type == 46)
							{
								Main.dust[i].scale += 0.1f;
							}
							else
							{
								Main.dust[i].scale += 0.03f;
							}
							if (Main.dust[i].scale > Main.dust[i].fadeIn)
							{
								Main.dust[i].fadeIn = 0f;
							}
						}
						else
						{
							Main.dust[i].scale -= 0.01f;
						}
						if (Main.dust[i].noGravity)
						{
							Dust expr_10D8 = Main.dust[i];
							expr_10D8.velocity *= 0.92f;
							if (Main.dust[i].fadeIn == 0f)
							{
								Main.dust[i].scale -= 0.04f;
							}
						}
						if (Main.dust[i].position.Y > Main.screenPosition.Y + (float)Main.screenHeight)
						{
							Main.dust[i].active = false;
						}
						if ((double)Main.dust[i].scale < 0.1)
						{
							Main.dust[i].active = false;
						}
					}
				}
				else
				{
					Main.dust[i].active = false;
				}
			}
		}
		public Color GetAlpha(Color newColor)
		{
			int r;
			int g;
			int b;
			if (this.type == 15 || this.type == 20 || this.type == 21 || this.type == 29 || this.type == 35 || this.type == 41 || this.type == 44 || this.type == 27 || this.type == 45)
			{
				r = (int)newColor.R - this.alpha / 3;
				g = (int)newColor.G - this.alpha / 3;
				b = (int)newColor.B - this.alpha / 3;
			}
			else
			{
				if (this.type == 43)
				{
					r = (int)newColor.R - this.alpha / 10;
					g = (int)newColor.G - this.alpha / 10;
					b = (int)newColor.B - this.alpha / 10;
				}
				else
				{
					r = (int)newColor.R - this.alpha;
					g = (int)newColor.G - this.alpha;
					b = (int)newColor.B - this.alpha;
				}
			}
			int num = (int)newColor.A - this.alpha;
			if (num < 0)
			{
				num = 0;
			}
			if (num > 255)
			{
				num = 255;
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
	}
}
