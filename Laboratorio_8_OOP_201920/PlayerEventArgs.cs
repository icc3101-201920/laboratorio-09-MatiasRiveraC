using Laboratorio_8_OOP_201920.Cards;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_8_OOP_201920
{
	public class PlayerEventArgs: EventArgs
	{
		Card carta;
		Player player;

		public Player Player { get => this.player; set => this.player = value; }
		public Card Carta { get => carta; set => carta = value; }
	}
}
