# GestioneProduzione2009

## Compilazione

### Dipendenze
Il progetto dipende da questi progetti

- [GestioneProduzione2014Plugins](https://github.com/aleven/GestioneProduzione2014Plugins)
- [VS2005Commons](https://github.com/aleven/VS2005Commons)

### Build Events

	copy $(ProjectDir)*.rpt $(TargetDir)
	copy $(ProjectDir)immagini\*.png $(TargetDir)

## Installazione

### Installazione 32bit
Installare

1. GestioneProduzione2009Setup_x86.msi (programma a 32 bit)
2. CRRedist2005_x86.msi (motore delle stampe a 32 bit)

### Installazione 64bit
Installare

1. GestioneProduzione2009Setup_x64.msi (programma a 64 bit)
2. CRRedist2005_X64.msi (motore delle stampe a 64 bit)

NOTA: verificare che nel computer non sia stata installata precedente la versione a 32 bit dei programmi

- Gestione Produzione 2009
- Crystal Report Runtime

Nel caso ci sia un conflitto fra 32 e 64 bit succede che il pulsante Stampa non funziona

