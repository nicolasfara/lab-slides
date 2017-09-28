﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unibo.ISI.ProgramazioneAdOggetti.Esercitazioni
{
  class EnvironmentManager : BaseEnvironmentManager
  {
    private Bitmap backgroundBmp;

    public EnvironmentManager(int width, int height)
      : base(width, height)
    {
      // Crea la bitmap di background
      backgroundBmp = new Bitmap(width, height);
      using (var gr = Graphics.FromImage(backgroundBmp)) // gr permette di "disegnare" su backgroundBmp
      {
        /*
         * Esercitazione - Parte 4
         * 
         * N.B. L'implementazione di questo metodo non è indispensabile per il proseguimento dell'esercitazione:
         * può essere lasciato per ultimo ed eventualmente svolto in un secondo tempo.
         * 
         * Traccia per implementare questo metodo:
         * Usare un'istanza di SpriteLoader per aprire l'immagine "..\..\..\Images\Background.png" che contiene 
         * una riga di sprite con dimensione 32x32.
         * Leggere quindi i valori contenuti nel file di testo "..\..\..\Data\Background.txt": 
         * si tratta di numeri interi separati da virgole: ogni numero è l'indice (di colonna) dello sprite da 
         * collocare nella corrispondente posizione del background (come se si disponessero delle piastrelle su un
         * pavimento).
         * Per semplicità, assumere che le dimensioni width/height del background siano multiple di 32 e che 
         * il file contenga sufficenti dati per coprire tutta la superficie del background.
         * Come leggere i dati dal file di testo? Ci sono vari modi, controllare ad esempio fra i metodi della classe 
         * statica File nella documentazione msdn oppure cercare un esempio di lettura di file di testo in C# su internet.
         * Per copiare una bitmap bmp dentro a backgroundBmp in posizione x,y, usare il seguente metodo:
         *       gr.DrawImage(bmp, x, y);
         */

        gr.FillRectangle(Brushes.DarkGreen, envRect); // N.B. questa riga potrà essere eliminata se si implementa quanto richiesto

      }
    }

    protected override BaseEnvironmentManager.OrganismInfo TryAddOrganism(IOrganism organism, int x, int y)
    {
      /*
       * Esercitazione - Parte 4
       * Traccia per implementare questo metodo:
       * - Creare un'istanza di OrganismInfo impostandone opportunamente le proprietà.
       * - Controllare se il BoundingBox dell'organismo è contenuto in envRect (con un metodo apposito 
       *   della struct Rectangle) e se è libero (con IsRegionEmpty definito in questa classe):
       *   in caso affermativo ritornare il riferimento al OrganismInfo creato, altrimenti tornare null.
       */
      throw new NotImplementedException();
    }

    /// <summary>
    /// Restituisce true se il rettangolo region non interseca
    /// alcun bounding box degli organismi, eccetto l'organismo excluded.
    /// </summary>
    private bool IsRegionEmpty(Rectangle region, OrganismInfo excluded)
    {
      return !organisms.Where(x => x != excluded).Any(x => x.BoundingBox.IntersectsWith(region));
    }

    protected override void DrawBackground(Graphics gr)
    {
      gr.DrawImage(backgroundBmp, 0, 0);
    }

    public override void AdvanceTime()
    {
      base.AdvanceTime();
      foreach (var o in organisms)
      {
        Direction dir = o.Direction;
        int speed = o.Speed;
        o.Organism.UpdateBehaviour(ref dir, ref speed);
        o.Direction = dir;
        o.Speed = speed;
        TryMove(o);
      }
    }

    /// <summary>
    /// Se l'organismo o si può muovere nella direzione e con la velocità desiderata,
    /// aggiorna la posizione di "o" e ritorna true, altrimenti ritorna false.
    /// </summary>
    private bool TryMove(OrganismInfo o)
    {
      /*
       * Esercitazione - Parte 4
       * Traccia per implementare questo metodo: la variabile locale rect
       * può essere spostata di un offset (dx,dy) calcolato in base a o.Direction e a o.Speed.
       * Ad esempio, se o.Direction è Direction.North e o.Speed è 3, allora dx = 0 e dy = -3.
       * Dopo aver calcolato dx e dy, trovare fra i metodi della struct Rectangle qual è il 
       * più idoneo a spostare il rettango appunto di dx e dy.
       * A questo punto il movimento è valido se rect:
       *   1) è contenuto dentro a envRect (trovare un apposito metodo per verificarlo...) e
       *   2) nessun altro organismo eccetto "o" occupa la regione rect (usare il metodo 
       *      IsRegionEmpty di questa classe...).
       * Se il movimento è valido, aggiornare o.X e o.Y e tornare true, altrimenti false.
       */
      Rectangle rect = o.BoundingBox;
      throw new NotImplementedException();
    }
  }
}