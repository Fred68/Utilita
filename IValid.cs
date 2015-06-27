namespace Fred68.Tools.Utilita
	{
	/// <summary> Interfaccia per classi i cui dati devono esser verificati </summary>
	interface IValid 
		{
		void Validate();
		bool IsValid {get;}	
		}
	}