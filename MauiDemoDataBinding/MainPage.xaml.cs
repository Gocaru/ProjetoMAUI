﻿using MauiDemoDataBinding.Models;

namespace MauiDemoDataBinding
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {

        }



        //private void OnCounterClicked(object sender, EventArgs e)
        //{
        //    var produto = new Produto
        //    {
        //        Nome = "IPhone 5",
        //        Preco = 5000.00m,
        //        Stock = 5
        //    };

        //Binding produtoBinding = new Binding();
        //produtoBinding.Source = produto;
        //produtoBinding.Path = "Nome";

        //Binding nomeBinding = new Binding
        //{
        //    Source = produto,
        //    Path = "Nome",
        //    StringFormat = "Produto: {0}"
        //};

        //lblNome.SetBinding(Label.TextProperty, nomeBinding);

        //Binding precoBinding = new Binding
        //{
        //    Source = produto,
        //    Path = "Preco",
        //    StringFormat = "Preço: {0}"
        //};

        //lblPreco.SetBinding(Label.TextProperty, precoBinding);

        //Binding stockBinding = new Binding
        //{
        //    Source = produto,
        //    Path = "Stock",
        //    StringFormat = "Stock: {0}"
        //};

        //lblStock.SetBinding(Label.TextProperty, stockBinding);

        //}
    }
}
