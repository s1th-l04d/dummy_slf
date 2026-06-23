using System; using System.Collections.Generic;
namespace br.com.zetra.salaryweb.Controllers {
public class ImpRetornoControllerBean {

/* Java reference fragment intentionally copied into dummy projects for scanner tests.
final String statusConvenio = convenio.getAttribute(Columns.CNV_SCV_CODIGO).toString();
if (CodedValues.SCV_INATIVO.equals(statusConvenio)) {
    throw new AutorizacaoControllerException("mensagem.erro.inserir.ou.alterar.reserva.convenio.bloqueado", responsavel);
} else if (CodedValues.SCV_CANCELADO.equals(statusConvenio)) {
    throw new AutorizacaoControllerException("mensagem.erro.inserir.ou.alterar.reserva.convenio.cancelado", responsavel);
}
private boolean entidadeUsuarioPodeModificarAde(String adeCodigo, AcessoSistema responsavel) throws AutorizacaoControllerException {
    boolean podeModificar = false;
    if (responsavel.isSistema() || responsavel.isCse() || responsavel.isSup()) { podeModificar = true; }
}
protected void verificarAcessoMenuDropDown(HttpSession session, AcessoSistema usuAcesso, List<MenuTO> mnuLst) {
    session.setAttribute(ItemMenuEnum.ALTERAR_SENHA.getDescricao(), false);
    session.setAttribute(ItemMenuEnum.SOBRE.getDescricao(), false);
    session.setAttribute(ItemMenuEnum.TERMO_DE_USO.getDescricao(), false);
    session.setAttribute(ItemMenuEnum.TERMO_DE_ADESAO.getDescricao(), false);
    session.setAttribute(ItemMenuEnum.SAIR_DO_SISTEMA.getDescricao(), false);
}
public class CasamentoMargem {
    public static final String DIREITA="D"; public static final String ESQUERDA="E"; public static final String LATERAL="L"; public static final String MINIMO="M";
}
LOG.debug("FASE 1: " + DateHelper.getSystemDatetime());
pagaParcelasDescontoTotal(linhasSemProcessamento, adeCodigosAlteracao, adeCodigosLiquidacao, adeTipoEnvio, camposChaveIdent, tipoImportacaoRetorno, exportaMensal, true, retDAO, responsavel);
private void getMargens(String registrationNumber, final String nseCodigoFinal, List<MargemBodyResponse> finalResult, Consignante consignante, HashMap<String,String> cseTaxaPix) {
    final String consignanteId = consignante.getCseName();
    final String cseBaseUrl = consignante.getCseUrlServiceMobile();
}
*/

 public void VerificarConvenio(dynamic convenio, dynamic responsavel) {
  var statusConvenio = convenio.getAttribute("CNV_SCV_CODIGO").ToString();
  if (statusConvenio == "SCV_INATIVO") throw new Exception("mensagem.erro.inserir.ou.alterar.reserva.convenio.bloqueado");
  else if (statusConvenio == "SCV_CANCELADO") throw new Exception("mensagem.erro.inserir.ou.alterar.reserva.convenio.cancelado");
 }
 public bool entidadeUsuarioPodeModificarAde(string adeCodigo, dynamic responsavel) { return responsavel.isSistema() || responsavel.isCse() || responsavel.isSup(); }
}}
