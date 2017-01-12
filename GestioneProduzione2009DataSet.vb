Imports VS2005Commons

Partial Class GestioneProduzione2009DataSet

    Public Sub AggiornaPrezziListinoRicambi()

        If (t26_formule_prezzi Is Nothing Or t26_formule_prezzi.Rows.Count = 0) Then
            Throw New Exception("Caricare in memoria le formule prezzi!")
        End If

        For Each articolo As ListinoRicambiRow In ListinoRicambi

            ' Se il prezzo forzato e' nullo o zero faccio i calcoli con la formula
            If articolo.Ist20_prezzo_forzatoNull Or articolo.t20_prezzo_forzato = 0 Then

                For Each rigaFormulaPrezzi As t26_formule_prezziRow In t26_formule_prezzi

                    Dim costo_articolo As Decimal = 0
                    Dim prezzo_calcolato As Decimal = 0
                    If Not articolo.Ist20_prezzoNull Then
                        costo_articolo = articolo.t20_prezzo
                    End If

                    ' Verifico in quale range rientro
                    If costo_articolo >= rigaFormulaPrezzi.t26_formula_da And costo_articolo < rigaFormulaPrezzi.t26_formula_a Then
                        'Verifico se devo usare un prezzo fisso o calcolarlo
                        If rigaFormulaPrezzi.Ist26_prezzo_fissoNull Then
                            prezzo_calcolato = articolo.t20_prezzo * rigaFormulaPrezzi.t26_fattore

                            'Dim arrotondamento As Decimal = 0
                            'If (rigaFormulaPrezzi.Ist26_arrotondamentoNull) Then
                            '    'rigaFormulaPrezzi.t26_arrotondamento = arrotondamento
                            'Else
                            '    arrotondamento = rigaFormulaPrezzi.t26_arrotondamento
                            'End If

                            '' Gestione arrotondamento
                            'Dim decimali As Decimal
                            'decimali = prezzo_calcolato Mod 1
                            'Dim parteIntera As Integer
                            'parteIntera = Math.Floor(prezzo_calcolato)
                            'If arrotondamento = 0.5 Then
                            '    If decimali > 0 And decimali < 0.5 Then
                            '        prezzo_calcolato = CDec(parteIntera + 0.5)
                            '    Else
                            '        prezzo_calcolato = parteIntera + 1
                            '    End If
                            'ElseIf arrotondamento = 1 Then
                            '    prezzo_calcolato = Math.Ceiling(prezzo_calcolato)
                            'Else
                            'End If

                            'prezzo_calcolato = Decimal.Round(prezzo_calcolato, 2)

                            If (rigaFormulaPrezzi.Ist26_arrotondamentoNull) Then
                                prezzo_calcolato = PrezziUtils.arrotondaPrezzo(prezzo_calcolato, PrezziUtils.arrotondamento.nessuno)
                            ElseIf rigaFormulaPrezzi.t26_arrotondamento = 0.5 Then
                                prezzo_calcolato = PrezziUtils.arrotondaPrezzo(prezzo_calcolato, PrezziUtils.arrotondamento.mezzo_euro_successivo)
                            ElseIf rigaFormulaPrezzi.t26_arrotondamento = 1 Then
                                prezzo_calcolato = PrezziUtils.arrotondaPrezzo(prezzo_calcolato, PrezziUtils.arrotondamento.euro_successivo)
                            Else
                                prezzo_calcolato = PrezziUtils.arrotondaPrezzo(prezzo_calcolato, PrezziUtils.arrotondamento.nessuno)
                            End If

                        Else
                            prezzo_calcolato = rigaFormulaPrezzi.t26_prezzo_fisso
                            End If

                            articolo.t20_prezzo = prezzo_calcolato
                            Exit For
                        End If
                Next

            Else
                articolo.t20_prezzo = articolo.t20_prezzo_forzato
            End If

        Next

    End Sub


End Class
