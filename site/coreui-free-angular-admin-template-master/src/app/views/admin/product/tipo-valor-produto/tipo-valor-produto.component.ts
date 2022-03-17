import { PermissaoUsuario } from './../../../../view-model/response/security/permissao-usuario';
import { BsModalService, ModalDirective } from 'ngx-bootstrap/modal';
import { Component, OnInit, ViewChild } from '@angular/core';
import { TipoValorProduto } from '../../../../view-model/response/product/price/tipo-valor-produto';
import { AuthorizationService } from '../../../auth/authorization.service';
import { CookieConsertService } from '../../../cookie-consert/cookie-consert.service';
import { TipoValorProdutoService } from './tipo-valor-produto.service';
import { UsuarioResponse } from '../../../../view-model/response/security/usuario';

@Component({
  selector: 'app-tipo-valor-produto',
  templateUrl: './tipo-valor-produto.component.html',
  styleUrls: ['./tipo-valor-produto.component.scss']
})
export class TipoValorProdutoComponent implements OnInit {

  @ViewChild('largeModal') public largeModal: ModalDirective;
  @ViewChild('largeModalEdit') public largeModalEdit: ModalDirective;
  @ViewChild('largeModalRemove') public largeModalRemove: ModalDirective;

  acessoPermitido: boolean = false;
  permissaoSistema: PermissaoUsuario = new PermissaoUsuario();
  tiposValoresProdutos: TipoValorProduto[]=[];

  constructor(private authorizationService: AuthorizationService,
    private cookie: CookieConsertService,
    private modalService: BsModalService,
    private tipoValorProdutosService:TipoValorProdutoService) { }

    ngOnInit(): void {
      var valor : UsuarioResponse= JSON.parse(this.cookie.getCookie("usuario"));
      valor.permissaoUsuarios.forEach(permissao => {
      this.acessoPermitido = permissao.permissao.nome == "Root" ||  permissao.permissao.nome == "Administrador";
      this.permissaoSistema = permissao;
    });
    this.tipoValorProdutosService.getAll("TipoValorProduto").subscribe({
      next:(t)=>{
          debugger;
          this.tiposValoresProdutos = t;
      },
      error:(e)=>{
          console.log(e);
      }
    });

    }
    openCadastro(){
      this.largeModal.show();
    }
}
