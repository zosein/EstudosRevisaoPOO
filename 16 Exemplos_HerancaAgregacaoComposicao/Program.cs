using _16_Exemplos_HerancaAgregacaoComposicao;
//criando livros (existem fora da biblio)
LivroFisico livro1 = new LivroFisico("Os Detetives Selvagens", "Roberto Bolaño", 200);
Ebook livro2 = new Ebook("Clean Code", "Robert C. Martin", 5.2);

//criando biblio
Biblioteca biblio = new Biblioteca("Pública Central");

//add livros a biblioteca (agragação)
biblio.AddLivro(livro1);
biblio.AddLivro(livro2);

//exibe acervo
biblio.ExibirAcervo();
