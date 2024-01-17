using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanchesMac.Migrations
{
    /// <inheritdoc />
    public partial class PopularLanches : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId, DescricaoCurta, DescricaoDetalhada, EmEstoque, ImagemThumbnailUrl, ImagemUrl, IsLanchePreferido, Nome, Preco) " +
                "values(1, 'Pão Ovo Queijo e Presunto', 'Pão feito com molho de tomate, ovo, presunto, queijo, tudo assado na chapa', 1," +
                " 'https://www.estadao.com.br/resizer/8rf9HcclTbHiBU6pRa36E01HHGE=/964x503/filters:format(jpg):quality(80)/cloudfront-us-east-1.images.arcpublishing.com/estadao/M7YQEG5KPJMPTHEMFZYCWYY7IA.jpg', " +
                "'https://www.estadao.com.br/resizer/8rf9HcclTbHiBU6pRa36E01HHGE=/964x503/filters:format(jpg):quality(80)/cloudfront-us-east-1.images.arcpublishing.com/estadao/M7YQEG5KPJMPTHEMFZYCWYY7IA.jpg', " +
                "1, 'Pão com Queijo', 12.99)");
            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId, DescricaoCurta, DescricaoDetalhada, EmEstoque, ImagemThumbnailUrl, ImagemUrl, IsLanchePreferido, Nome, Preco) " +
              "values(2, 'Pão Com Ovo', 'Pão feito com molho de tomate, ovo, presunto, queijo, tudo assado na chapa', 1," +
              " 'https://www.estadao.com.br/resizer/8rf9HcclTbHiBU6pRa36E01HHGE=/964x503/filters:format(jpg):quality(80)/cloudfront-us-east-1.images.arcpublishing.com/estadao/M7YQEG5KPJMPTHEMFZYCWYY7IA.jpg', " +
              "'https://www.estadao.com.br/resizer/8rf9HcclTbHiBU6pRa36E01HHGE=/964x503/filters:format(jpg):quality(80)/cloudfront-us-east-1.images.arcpublishing.com/estadao/M7YQEG5KPJMPTHEMFZYCWYY7IA.jpg', " +
              "1, 'Pão com Queijo', 19.98)");
            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId, DescricaoCurta, DescricaoDetalhada, EmEstoque, ImagemThumbnailUrl, ImagemUrl, IsLanchePreferido, Nome, Preco) " +
              "values(1, 'Pão Ovo Queijo e Presunto', 'Pão feito com molho de tomate, ovo, presunto, queijo, tudo assado na chapa', 1," +
              " 'https://www.estadao.com.br/resizer/8rf9HcclTbHiBU6pRa36E01HHGE=/964x503/filters:format(jpg):quality(80)/cloudfront-us-east-1.images.arcpublishing.com/estadao/M7YQEG5KPJMPTHEMFZYCWYY7IA.jpg', " +
              "'https://www.estadao.com.br/resizer/8rf9HcclTbHiBU6pRa36E01HHGE=/964x503/filters:format(jpg):quality(80)/cloudfront-us-east-1.images.arcpublishing.com/estadao/M7YQEG5KPJMPTHEMFZYCWYY7IA.jpg', " +
              "1, 'Pão com Queijo', 11.50)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Lanches");
        }
    }
}
