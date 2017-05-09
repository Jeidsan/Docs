using System;
using System.Collections.Generic;
using System.Text;

namespace Docs.Domain.Base
{
    /// <summary>
    /// Especifica os serviços mínimos que deverão ser atendidos por um servidor de nomes do sistema.
    /// </summary>
    public interface INameServer
    {
        /// <summary>
        /// Registra um processo no sistema.
        /// </summary>
        /// <param name="process">Processo a ser registrado.</param>
        /// <param name="uri">Endereço para acesso ao processo.</param>
        /// <returns>Identificador do processo no sistema.</returns>
        Guid Register(IProcess process, string uri);

        /// <summary>
        /// Registraum novo recurso no sistema.
        /// </summary>
        /// <param name="resource">Recurso a ser registrado no sistema.</param>
        /// <param name="uri">Endereço para acesso ao recurso.</param>
        /// <returns>Identificador do recurso no sistema.</returns>
        Guid Register(IResource resource, string uri);

        /// <summary>
        /// Cancela o registro de um processo ou recurso do sistema.
        /// </summary>
        /// <param name="process">Identificador do processo ou recurso a ser excluido.</param>
        void Unregister(Guid identifier);

        /// <summary>
        /// Lista os processos cadastrados no sistema.
        /// </summary>
        /// <returns>Retorna a lista com o identiicador </returns>
        Dictionary<Guid, string> GetProcesses();

        Dictionary<Guid, string> GetResources();
    }
}
