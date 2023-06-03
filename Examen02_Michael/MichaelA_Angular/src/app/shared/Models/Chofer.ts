import { LicenciaChofer } from "./LicenciaChofer"

export interface Chofer {
    Cedula: string

    Nombre: string

    Apellido1: string

    Apellido2: string

    TbLicenciaChofers: LicenciaChofer[]
}