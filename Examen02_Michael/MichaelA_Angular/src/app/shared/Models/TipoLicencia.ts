import { LicenciaChofer } from "./LicenciaChofer"

export interface TipoLicencia {
    idTipoLicencia: string

    descripcion: string

    Estado: boolean

    TbLicenciaChofers: LicenciaChofer[]
}