﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unibo.ISI.ProgramazioneAdOggetti.Esercitazioni
{

  class SimpleEnvironmentManager : BaseEnvironmentManager
  {
    public SimpleEnvironmentManager(int width, int height)
      : base(width, height)
    {
    }

    const int maxOrganisms = 10; // numero massimo di organismi

    protected override OrganismInfo TryAddOrganism(IOrganism organism, int x, int y)
    {
      /* Esercitazione - Parte 3
       * 
       * Definire un numero massimo di organismi con una costante (es. 10).
       * Se il numero attuale di organismi (ottenibile dalla struttura dati protetta in BaseEnvironmentManager)
       * è inferiore al massimo consentito, costruire e restituire un'opportuna istanza di OrganismInfo,
       * altrimenti restituire null.
       * Nel caso in cui si restituisca un'istanza di OrganismInfo, impostare in maniera psudo-causale il valore
       * della proprietà Direction (suggerimento: notare che le quattro direzioni corrispondono ai valori [0..3]).
       */
      if (organisms.Count < maxOrganisms)
      {
        // Utilizza la sintassi object initializer per inizializzare alcune proprietà
        return new OrganismInfo 
        {
          X = x,
          Y = y,
          Organism = organism,
          Direction = (Direction)Random(4), // Sceglie una delle quattro direzioni in modo random
        };
      }
      else
      {
        return null;
      }
    }

    protected override void DrawBackground(Graphics gr)
    {
      gr.FillRectangle(Brushes.DarkGreen, envRect);
    }
  }
}
