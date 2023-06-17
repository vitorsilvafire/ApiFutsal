using Microsoft.EntityFrameworkCore;
using ApiFutsal.Models;
using ApiFutsal.Models.Enuns;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ApiFutsal.Data;
using System.ComponentModel.DataAnnotations;
using System.Data;
namespace ApiFutsal.Data
{
    public class DataContext : DbContext
    {
       public DataContext(DbContextOptions<DataContext> options) : base(options)
       {
        
       } 
       public DbSet<Jogadores> Jogadores { get; set; }
         public DbSet<Camisa> Camisa { get; set; }
       protected override void OnModelCreating(ModelBuilder modelBuilder)
       {
        modelBuilder.Entity<Jogadores>().HasData
        (
            new Jogadores() { Id = 1, Nome = "Gustavo Almeida", Responsavel = "Isrraela", CPF = "509885211-11", Posicao=PosicaoEnum.Goleiro},
            new Jogadores() { Id = 2, Nome = "Heverson", Responsavel = "Cindir", CPF = "455202582-27", Posicao=PosicaoEnum.Goleiro},
            new Jogadores() { Id = 3, Nome = "Cauã", Responsavel = "Daniela", CPF = "523648782-19", Posicao=PosicaoEnum.Fixo },
            new Jogadores() { Id = 4, Nome = "Matheus", Responsavel = "Carmem", CPF = "485213251-15", Posicao=PosicaoEnum.Fixo },
            new Jogadores() { Id = 5, Nome = "Kauan", Responsavel = "Aline", CPF = "502202144-46", Posicao=PosicaoEnum.Ala },
            new Jogadores() { Id = 6, Nome = "Daniel", Responsavel = "Lurdes", CPF = "648558967-79", Posicao=PosicaoEnum.Ala },
            new Jogadores() { Id = 7, Nome = "Luan", Responsavel = "Cleide", CPF = "002147858-44", Posicao=PosicaoEnum.Ala },
            new Jogadores() { Id = 8, Nome = "Kaue", Responsavel = "Charlene", CPF = "124525428-88", Posicao=PosicaoEnum.Ala },
            new Jogadores() { Id = 9, Nome = "Weverton", Responsavel = "Geraldina", CPF = "889652125-45", Posicao=PosicaoEnum.Pivo },
            new Jogadores() { Id = 10, Nome = "Gustavo", Responsavel = "Erismelk", CPF = "551031366-84", Posicao=PosicaoEnum.Pivo },
            new Jogadores() { Id = 11, Nome = "Lucas", Responsavel = "Tatiana", CPF = "554102123-54", Posicao=PosicaoEnum.Pivo }
        );
        modelBuilder.Entity<Camisa>().HasData
        (
            new Camisa() {CamisaId = 1, CamisaNumero = 1, JogadorId = 1},
            new Camisa() {CamisaId = 2, CamisaNumero = 2, JogadorId = 2},
            new Camisa() {CamisaId = 3, CamisaNumero = 3,  JogadorId = 3},
            new Camisa() {CamisaId = 4, CamisaNumero = 4,  JogadorId = 4},
            new Camisa() {CamisaId = 5, CamisaNumero = 5, JogadorId = 5},
            new Camisa() {CamisaId = 6, CamisaNumero = 6, JogadorId = 6},
            new Camisa() {CamisaId = 7, CamisaNumero = 7, JogadorId = 7},
            new Camisa() {CamisaId = 8, CamisaNumero = 8, JogadorId = 8},
            new Camisa() {CamisaId = 9, CamisaNumero = 9, JogadorId = 9},
            new Camisa() {CamisaId = 10, CamisaNumero = 10, JogadorId = 10},
            new Camisa() {CamisaId = 11, CamisaNumero = 11, JogadorId = 11}
        );
    }
}
}